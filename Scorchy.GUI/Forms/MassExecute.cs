using MetroFramework;
using MetroFramework.Forms;
using Scorchy.Core.Interfaces;
using Scorchy.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scorchy.GUI.ExtensionMethods;

namespace Scorchy.GUI.Forms
{
    public partial class MassExecute : MetroForm
    {
        private BackgroundWorker worker;
        private IRunbookInteractionProvider _orch;
        private Guid rbId;
        public MassExecute(RunbookObject rb,IEnumerable<Parameter> parameters, IRunbookInteractionProvider provider)
        {
            InitializeComponent();
            labelRunbookName.Text = rb.Name;
            prepareGrid(parameters);
            _orch = provider;
            rbId = rb.RunbookId;
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.ProgressChanged += worker_ProgressChanged;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            executeProgressbar.Value = (int)Math.Floor(e.ProgressPercentage / ((double)gridParameters.RowCount - 1) * 100);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                MetroMessageBox.Show(this, string.Format("{0} runbooks successfully executed", gridParameters.RowCount-1), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridParameters.Rows.Clear();
            }
            else if (e.Cancelled)
            {
                MetroMessageBox.Show(this, "Execution of runbooks is cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MetroMessageBox.Show(this, string.Format("Error while trying to execute {0} runbooks", gridParameters.RowCount-1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Execute.Enabled = true;
            executeProgressbar.Visible = false;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker wrk = (BackgroundWorker)sender;
            var rbps = (List<List<Parameter>>)e.Argument;
            var rbid = rbps.First().First().RunbookId;
            var counter = 1;
            foreach (List<Parameter> singleListOfParameters in rbps)
            {
                if (!wrk.CancellationPending)
                {
                    PerformHeavyOperation(singleListOfParameters);
                    wrk.ReportProgress(counter);
                    counter++;
                }
                else
                {
                    e.Cancel = true;
                    break;
                }
            }
            e.Result = "Work completed";
        }

        private int PerformHeavyOperation(List<Parameter> singleListOfParameters)
        {
            _orch.ExecuteRunbook(rbId, singleListOfParameters);
            return singleListOfParameters.Count;
        }

        private void prepareGrid(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter p in parameters)
            {
                gridParameters.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = p.Guid.ToString(), HeaderText = p.Name });
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {

            if (!worker.IsBusy)
            {
                var rbps = new List<List<Parameter>>();
                foreach (DataGridViewRow row in gridParameters.Rows)
                {
                    var elem = new List<Parameter>();
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell c in row.Cells)
                        {
                            elem.Add(new Parameter()
                            {
                                Name = c.OwningColumn.HeaderText,
                                Guid = Guid.Parse(c.OwningColumn.DataPropertyName),
                                Value = c.Value.ToString(),
                                RunbookId = rbId
                            });
                        }
                        rbps.Add(elem);
                    }
                }
                executeProgressbar.Visible = true;
                Execute.Text = "Cancel";
                worker.RunWorkerAsync(rbps);
            }
            else
            {
                worker.CancelAsync();
                Execute.Text = "Execute";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void gridParameters_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Insert || e.Control && e.KeyCode == Keys.V)
            {
                //shift-insert or control-v pressed
                IDataObject data = Clipboard.GetDataObject();
                if (data.GetDataPresent(DataFormats.Text))
                {
                    char[] rowSeparators = { '\r', '\n' };
                    char[] columnSeparator = { '\t' };
                    string strings = (string)data.GetData(DataFormats.Text);
                    string[] rows = strings.Split(rowSeparators, StringSplitOptions.RemoveEmptyEntries);
                    string[] columns = rows[1].Split(columnSeparator, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length > 1)
                    {
                        return;
                    }
                    int column = gridParameters.SelectedCells[0].ColumnIndex;
                    int row = gridParameters.SelectedCells[0].RowIndex;
                    if (gridParameters.RowCount < (gridParameters.SelectedCells[0].RowIndex + rows.Length))
                    {
                        gridParameters.Rows.Add(rows.Length);
                    }
                    for (int i = 0; i < rows.Length; i++)
                    {
                        gridParameters.Rows[row + i].Cells[0].Value = rows[i];
                    }
                }
            }
        }
    }
}
