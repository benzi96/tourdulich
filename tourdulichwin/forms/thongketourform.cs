using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.bus;

namespace tourdulichwin.forms
{
    public partial class thongketourform : Form
    {
        thongketourbus tktbus;
        giatourbus gtbus = new giatourbus();
        public thongketourform()
        {
            InitializeComponent();
            tktbus = new thongketourbus();
            comboBox1.DataSource = new BindingSource(gtbus.listt(), null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idtour = Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key);
            dataGridView1.DataSource = tktbus.thongkedoanhthu(idtour, dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
