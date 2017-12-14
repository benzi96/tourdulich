using Core.bus;
using Core;
using System;
using System.Windows.Forms;

namespace tourdulichwin.forms
{
    public partial class loaihinhdulichform : Form
    {
        private int currentid;
        loaihinhdulichbus lhbus;
        public loaihinhdulichform()
        {
            InitializeComponent();
            lhbus = new loaihinhdulichbus();
        }

        #region event
        private void themlhbtn_Click(object sender, EventArgs e)
        {
            loaihinhdulich lh = new loaihinhdulich();
            lh.tenloaihinh = tenlhtxt.Text;
            bool s = lhbus.loaihinhdulichrespository.Add(lh);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(loaihinhpanel);
                loadloaihinhdulichdgv();
            }
        }

        private void loaihinhdulichdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            endeditbtn.Visible = true;
            sualhbtn.Enabled = true;
            themlhbtn.Enabled = false;
            if (loaihinhdulichdgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in loaihinhdulichdgv.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    tenlhtxt.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void endeditbtn_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }

        private void sualhbtn_Click(object sender, EventArgs e)
        {
            loaihinhdulich lh = new loaihinhdulich();
            lh.id = currentid;
            lh.tenloaihinh = tenlhtxt.Text;
            bool s = lhbus.update(lh);
            helpers.successorerror(s);
            if (s)
            {
                exiteditingmode();
                loadloaihinhdulichdgv();
            }
        }
        #endregion

        #region method
        public void loadloaihinhdulichdgv()
        {
            loaihinhdulichdgv.DataSource = lhbus.list();
        }

        private void exiteditingmode()
        {
            helpers.ClearOnlyTextBoxes(loaihinhpanel);
            themlhbtn.Enabled = true;
            sualhbtn.Enabled = false;
            endeditbtn.Visible = false;
            currentid = -1;
        }
        #endregion
    }
}
