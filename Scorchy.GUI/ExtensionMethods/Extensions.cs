using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scorchy.GUI.ExtensionMethods
{
    public static class Extensions
    {
        public static DataTable ToDataTable(this DataGridView dgv)
        {
            var dt = new DataTable();
            for (int i = 0; i < dgv.Columns.Count; i++)
			{
                dt.Columns.Add(dgv.Columns[i].DataPropertyName);
			}
            foreach (DataGridViewRow r in dgv.Rows)
            {
                var dr = dt.NewRow();
                for (int j = 0; j < r.Cells.Count; j++)
                {
                    dr[j] = r.Cells[j].Value;
                }
                dt.Rows.Add(r);
            }
            return dt;
        }
    }
}
