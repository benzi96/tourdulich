using Core.bus;
using Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tourdulichwin.forms
{
    public partial class diadiemform : Form
    {
        private int currentid;
        diadiembus ddbus;
        public diadiemform()
        {
            InitializeComponent();
            ddbus = new diadiembus();

            tenttcbb.DataSource = new BindingSource(ddbus.listtt(), null);
            tenttcbb.DisplayMember = "Value";
            tenttcbb.ValueMember = "Key";
        }

        #region event
        private void themddbtn_Click(object sender, EventArgs e)
        {
            diadiem dd = new diadiem();
            dd.tendiadiem = tenddtxt.Text;
            dd.idtt = Convert.ToInt32(((KeyValuePair<string, string>)tenttcbb.SelectedItem).Key);
            bool s = ddbus.add(dd);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(diadiempanel);
                loaddiadiemdgv();
            }
        }

        private void diadiemdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            endeditbtn.Visible = true;
            suaddbtn.Enabled = true;
            themddbtn.Enabled = false;
            if (tinhthanhdgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tinhthanhdgv.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tenddtxt.Text = row.Cells[1].Value.ToString();
                    tenttcbb.SelectedIndex = tenttcbb.FindString(row.Cells[2].Value.ToString());
                }
            }
        }

        private void endeditbtn_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }

        private void suaddbtn_Click(object sender, EventArgs e)
        {
            diadiem dd = new diadiem();
            dd.id = currentid;
            dd.tendiadiem = tenddtxt.Text;
            dd.idtt = Convert.ToInt32(((KeyValuePair<string, string>)tenttcbb.SelectedItem).Key);
            bool s = ddbus.update(dd);
            helpers.successorerror(s);
            if (s)
            {
                exiteditingmode();
                loaddiadiemdgv();
            }
        }

        #endregion

        #region method
        public void loaddiadiemdgv()
        {
            tinhthanhdgv.DataSource = ddbus.list();
        }

        private void exiteditingmode()
        {
            helpers.ClearOnlyTextBoxes(diadiempanel);
            themddbtn.Enabled = true;
            suaddbtn.Enabled = false;
            endeditbtn.Visible = false;
            currentid = -1;
        }
        #endregion

    }
}
