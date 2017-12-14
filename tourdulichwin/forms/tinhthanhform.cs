using Core.bus;
using Core;
using System;
using System.Windows.Forms;

namespace tourdulichwin.forms
{
    public partial class tinhthanhform : Form
    {
        private int currentid;
        tinhthanhbus ttbus;
        public tinhthanhform()
        {
            InitializeComponent();
            ttbus = new tinhthanhbus();
        }

        #region event
        private void themttbtn_Click(object sender, EventArgs e)
        {
            tinhthanh tt = new tinhthanh();
            tt.matt = matttxt.Text;
            tt.tentt = tentttxt.Text;
            bool s = ttbus.tinhthanhrespository.Add(tt);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(tinhthanhpanel);
                loadtinhthanhdgv();
            }
        }

        private void tinhthanhdgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            endeditbtn.Visible = true;
            suattbtn.Enabled = true;
            themttbtn.Enabled = false;
            if (tinhthanhdgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tinhthanhdgv.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    matttxt.Text = row.Cells[1].Value.ToString();
                    tentttxt.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void endeditbtn_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }

        private void suattbtn_Click(object sender, EventArgs e)
        {
            tinhthanh tt = new tinhthanh();
            tt.id = currentid;
            tt.matt = matttxt.Text;
            tt.tentt = tentttxt.Text;
            bool s = ttbus.update(tt);
            helpers.successorerror(s);
            if (s)
            {
                exiteditingmode();
                loadtinhthanhdgv();
            }
        }
        #endregion

        #region method
        public void loadtinhthanhdgv()
        {
            tinhthanhdgv.DataSource = ttbus.list();
        }

        private void exiteditingmode()
        {
            helpers.ClearOnlyTextBoxes(tinhthanhpanel);
            themttbtn.Enabled = true;
            suattbtn.Enabled = false;
            endeditbtn.Visible = false;
            currentid = -1;
        }
        #endregion

    }
}
