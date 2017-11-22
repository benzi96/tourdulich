using System;
using System.Windows.Forms;

namespace tourdulichwin.forms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void ttmenubtn_Click(object sender, EventArgs e)
        {
            tinhthanhform ttfr = new tinhthanhform();
            ttfr.Show();
            ttfr.loadtinhthanhdgv();
        }

        private void loaihinhmenubtn_Click(object sender, EventArgs e)
        {
            loaihinhdulichform lhfr = new loaihinhdulichform();
            lhfr.Show();
            lhfr.loadloaihinhdulichdgv();
        }

        private void ddmenubtn_Click(object sender, EventArgs e)
        {
            diadiemform ddfr = new diadiemform();
            ddfr.Show();
            ddfr.loaddiadiemdgv();
        }

        private void tourmenubtn_Click(object sender, EventArgs e)
        {
            tourform tfr = new tourform();
            tfr.Show();
            tfr.loadtourdgv();
        }

        private void giatourmenubtn_Click(object sender, EventArgs e)
        {
            giatourform gtfr = new giatourform();
            gtfr.Show();
            gtfr.loadgiatourdgv();
        }

        private void ctdtqmenubtn_Click(object sender, EventArgs e)
        {
            chitietdiemthamquanform ctdtqfr = new chitietdiemthamquanform();
            ctdtqfr.Show();
            ctdtqfr.loadchitietdiemthamquandgv();
        }

        private void tktourmenubtn_Click(object sender, EventArgs e)
        {
            thongketourform tktfr = new thongketourform();
            tktfr.Show();
        }

        private void thhdctmenubtn_Click(object sender, EventArgs e)
        {
            tinhhinhhoatdongtourform thfr = new tinhhinhhoatdongtourform();
            thfr.Show();
            thfr.loadtinhhinhhoatdongcuatourdgv();
        }
    }
}
