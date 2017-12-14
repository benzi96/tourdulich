using Core.bus;
using System.Windows.Forms;
using Core;
using System.Collections.Generic;
using System;

namespace tourdulichwin.forms
{
    public partial class tourform : Form
    {
        private int currentid;
        tourbus tbus;
        public tourform()
        {
            InitializeComponent();

            tbus = new tourbus();
            tenlhcbb.DataSource = new BindingSource(tbus.listlh(), null);
            tenlhcbb.DisplayMember = "Value";
            tenlhcbb.ValueMember = "Key";
        }

        #region event
        private void themtbtn_Click(object sender, EventArgs e)
        {
            tour t = new tour();
            t.tentour = tenttxt.Text;
            t.dacdiem = ddtxt.Text;
            t.idlh = Convert.ToInt32(((KeyValuePair<string, string>)tenlhcbb.SelectedItem).Key);
            bool s = tbus.add(t);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(tourpanel);
                loadtourdgv();
            }
        }

        private void tourdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            endeditbtn.Visible = true;
            suatbtn.Enabled = true;
            themtbtn.Enabled = false;
            if (tourdgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tourdgv.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tenttxt.Text = row.Cells[1].Value.ToString();
                    ddtxt.Text = row.Cells[2].Value.ToString();
                    tenlhcbb.SelectedItem = row.Cells[3].Value.ToString();
                }
            }
        }

        private void endeditbtn_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }

        private void suatbtn_Click(object sender, EventArgs e)
        {
            tour t = new tour();
            t.id = currentid;
            t.tentour = tenttxt.Text;
            t.dacdiem = ddtxt.Text;
            t.idlh = Convert.ToInt32(((KeyValuePair<string, string>)tenlhcbb.SelectedItem).Key);
            bool s = tbus.update(t);
            helpers.successorerror(s);
            if (s)
            {
                exiteditingmode();
                loadtourdgv();
            }
        }
        #endregion

        #region method
        public void loadtourdgv()
        {
            tourdgv.DataSource = tbus.list();
        }

        private void exiteditingmode()
        {
            helpers.ClearOnlyTextBoxes(tourpanel);
            themtbtn.Enabled = true;
            suatbtn.Enabled = false;
            endeditbtn.Visible = false;
            currentid = -1;
        }
        #endregion

    }
}
