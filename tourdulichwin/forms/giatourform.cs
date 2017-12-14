using Core.bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace tourdulichwin.forms
{
    public partial class giatourform : Form
    {
        private int currentid;
        giatourbus gtbus;
        public giatourform()
        {
            InitializeComponent();
            gtbus = new giatourbus();

            tentcbb.DataSource = new BindingSource(gtbus.listt(), null);
            tentcbb.DisplayMember = "Value";
            tentcbb.ValueMember = "Key";
        }

        #region event
        private void themgtbtn_Click(object sender, EventArgs e)
        {
            giatour gt = new giatour();
            gt.gia = giatournud.Value;
            gt.idtour = Convert.ToInt32(((KeyValuePair<string, string>)tentcbb.SelectedItem).Key);
            gt.tungay = tungaydtp.Value;
            gt.denngay = denngaydtp.Value;
            bool s = gtbus.add(gt);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(giatourpanel);
                loadgiatourdgv();
            }
        }

        private void giatourdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            endeditbtn.Visible = true;
            suagtbtn.Enabled = true;
            themgtbtn.Enabled = false;
            if (giatourdgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in giatourdgv.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tentcbb.SelectedItem = row.Cells[1].Value.ToString();
                    giatournud.Value = Convert.ToDecimal(row.Cells[2].Value.ToString());
                    tungaydtp.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                    denngaydtp.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                }
            }
        }

        private void endeditbtn_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }

        private void suagtbtn_Click(object sender, EventArgs e)
        {
            giatour gt = new giatour();
            gt.gia = giatournud.Value;
            gt.idtour = Convert.ToInt32(((KeyValuePair<string, string>)tentcbb.SelectedItem).Key);
            gt.tungay = tungaydtp.Value;
            gt.denngay = denngaydtp.Value;
            bool s = gtbus.update(gt);
            helpers.successorerror(s);
            if (s)
            {
                exiteditingmode();
                loadgiatourdgv();
            }
        }

        #endregion

        #region method
        public void loadgiatourdgv()
        {
            giatourdgv.DataSource = gtbus.list();
        }

        private void exiteditingmode()
        {
            helpers.ClearOnlyTextBoxes(giatourpanel);
            themgtbtn.Enabled = true;
            suagtbtn.Enabled = false;
            endeditbtn.Visible = false;
            currentid = -1;
        }
        #endregion
    }
}
