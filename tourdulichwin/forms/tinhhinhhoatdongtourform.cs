using bus.bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tourdulichwin.forms
{
    public partial class tinhhinhhoatdongtourform : Form
    {
        thongketourbus tktbus;
        public tinhhinhhoatdongtourform()
        {
            InitializeComponent();
            tktbus = new thongketourbus();
        }
        public void loadtinhhinhhoatdongcuatourdgv()
        {
            tinhhinhhoatdongtourdgv.DataSource = tktbus.tinhhinhhoatdong();
        }
    }
}
