﻿using bus.bus;
using entities;
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
    public partial class chitietdiemthamquanform : Form
    {
        chitietdiemthamquanbus ctdtqbus;
        public chitietdiemthamquanform()
        {
            InitializeComponent();
            ctdtqbus = new chitietdiemthamquanbus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chitietdiemthamquan ct = new chitietdiemthamquan();
            ct.idtour= Convert.ToInt32(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key);
            ct.iddiadiem= Convert.ToInt32(((KeyValuePair<string, string>)comboBox2.SelectedItem).Key);
            bool s = ctdtqbus.add(ct);
            helpers.successorerror(s);
            if (s)
            {
                helpers.ClearOnlyTextBoxes(panel1);
                loadchitietdiemthamquandgv();
            }
        }
        public void loadchitietdiemthamquandgv()
        {
            dataGridView1.DataSource = ctdtqbus.list();
        }
    }
}