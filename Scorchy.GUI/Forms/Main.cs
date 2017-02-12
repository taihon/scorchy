using MetroFramework.Forms;
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
using Scorchy.Core.Interfaces;
using Scorchy.Core.Providers;
using MetroFramework.Controls;
using MetroFramework;
using Scorchy.GUI.Classes;

namespace Scorchy.GUI.Forms
{
    public partial class Main : MetroForm
    {
        User _currentUser;
        OrchestratorProvider _orch;
        IEnumerable<RunbookObject> _runbooks;
        int job_current_page=0;
        int event_current_page=0;
        public Main(User usr)
        {
            InitializeComponent();
            _currentUser = usr;
            toolstripLoggedUser.Enabled = false;
            toolstripLoggedUser.Text = usr.Name;
            _orch = new OrchestratorProvider(usr.Credential, Settings.Instance.OrchestratorUrl);
            _runbooks = _orch.GetRunbooks();
            treeRunbooks.NodeMouseDoubleClick += treeRunbooks_NodeMouseDoubleClick;
            refreshTree();
        }

        void treeRunbooks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Guid g;
            if (Guid.TryParse(e.Node.Name, out g))
            {
                CreateInputsForRunbook(g);
            }
        }

        private void CreateInputsForRunbook(Guid g)
        {
            panelRunbookParameters.Controls.Clear();
            var rb = _runbooks.First(t=>t.RunbookId == g);
            var rbp = _orch.GetRunbookParameters(g);
            panelRunbookParameters.Controls.Add(
                new MetroLabel() {
                    Text = rb.Name,
                    Left=20,
                    Top = 20,
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoEllipsis=true,
                    AutoSize=true,
                    Tag = g
                }
            );
            foreach (var p in rbp)
            {
                var lbl = new MetroLabel()
                    {
                        Text = p.Name,
                        Width = 250,
                        Top = 30 + panelRunbookParameters.Controls.OfType<Label>().Count() * 30,
                        Left = 0,
                        TextAlign = ContentAlignment.MiddleRight
                    };
                panelRunbookParameters.Controls.Add(lbl);
                panelRunbookParameters.Controls.Add(
                    new MetroTextBox()
                    {
                        Top = lbl.Top,
                        Left = lbl.Right + 10,
                        Width = 350,
                        Tag = new RunbookTag() { Guid = p.Guid, Name = p.Name }
                    }
                );
            }
        }

        private void userMenu_Click(object sender, EventArgs e)
        {
            menuUser.Show(userMenu, new Point(40-menuUser.Width, 36));
        }

        private void toolstripLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Node buildTreeFromRunbooks()
        {
            Node root = new Node() { Name = "/" };
            foreach (RunbookObject obj in _runbooks.OrderBy(o => o.Path))
            {
                root.AddNodeWithParents(obj.Path, obj.RunbookId);
            }
            return root;
        }
        private void refreshTree()
        {
            var root = new TreeNode("/");
            treeRunbooks.Nodes.Clear();
            treeRunbooks.Nodes.Add(root);
            foreach (RunbookObject rb in _runbooks.OrderBy(r=>r.Path))
            {
                var current = root;
                if(rb.Path != null){
                    string[] path = rb.Path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < path.Length; i++)
                    {
                        var tag = i == path.Length-1 ? rb.RunbookId.ToString() : null;
                        current = AddNodeToTreeview(current, path[i], tag);
                    }
                }
            }
            treeRunbooks.ExpandAll();
        }

        private TreeNode AddNodeToTreeview(TreeNode current, string name, string tag)
        {
            if (current.Nodes.ContainsKey(name))
            {
                return current.Nodes[name];
            }
            else
            {
                return current.Nodes.Add(tag != null ? tag : name, name);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            //find rb guid
            Guid g = (Guid)panelRunbookParameters.Controls.OfType<MetroLabel>().First(l => l.Tag != null).Tag;
            var param = panelRunbookParameters.Controls.OfType<MetroTextBox>().Select(
                t =>
                    new Parameter()
                    {
                        Guid = ((RunbookTag)t.Tag).Guid,
                        RunbookId = g,
                        Value = t.Text,
                        Name = ((RunbookTag)t.Tag).Name
                    });
            if (_orch.ExecuteRunbook(g, param))
            {
                MetroMessageBox.Show(this, "Runbook successfully started", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (MetroTextBox mtbx in panelRunbookParameters.Controls.OfType<MetroTextBox>())
                    mtbx.Clear();
            }
            else
            {
                MetroMessageBox.Show(this, "Error while starting runbook", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRefreshEvents_Click(object sender, EventArgs e)
        {
            refreshEvents();
        }

        private void refreshEvents()
        {
            //eventsGrid.Rows.Clear();
            var source = new BindingSource();
            source.DataSource = _orch.GetEvents(Settings.Instance.RowsPerPage);
            gridEvents.DataSource = source;
            gridEvents.Refresh();
        }
        private void refreshJobs()
        {
            var source = new BindingSource();
            source.DataSource = _orch.GetJobs(Settings.Instance.RowsPerPage, job_current_page, Settings.Instance.ResolveSID);
            gridJobs.DataSource = source;
            gridJobs.Refresh();
        }

        private void buttonRefreshJobs_Click(object sender, EventArgs e)
        {
            refreshJobs();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelRunbookParameters.Controls.OfType<MetroTextBox>())
            {
                c.Text="";
            }
        }

        private void buttonMassExecute_Click(object sender, EventArgs e)
        {
            var rb = (Guid)panelRunbookParameters.Controls.OfType<MetroLabel>().First(l => l.Tag != null).Tag;
            var me = new MassExecute(_runbooks.First(r=>r.RunbookId == rb), _orch.GetRunbookParameters(rb), _orch);
            me.ShowDialog();
        }

        private void treeRunbooks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Guid g;
                if (Guid.TryParse(treeRunbooks.SelectedNode.Name, out g))
                {
                    CreateInputsForRunbook(g);
                }
            }
        }

        private void metroTextBox1_ButtonClick(object sender, EventArgs e)
        {
            if (gridJobs.DataSource == null)
            {
                var source = new BindingSource();
                source.DataSource = _orch.FindJobsByParameterValue(metroTextBox1.Text);
                gridJobs.DataSource = source;
            }
            else
            {
                ((BindingSource)gridJobs.DataSource).DataSource = _orch.FindJobsByParameterValue(metroTextBox1.Text);
                
            }
            
            gridJobs.Refresh();
        }

        private void buttonNextJobs_Click(object sender, EventArgs e)
        {
            job_current_page += 1;
            refreshJobs();
        }

        private void buttonPrevJobs_Click(object sender, EventArgs e)
        {
            if (job_current_page > 0)
                job_current_page -= 1;
            refreshJobs();
        }

        private void toolstripSettings_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingsManager();
            settingsDialog.ShowDialog();
        }
    }
}
