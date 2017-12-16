namespace tourdulichwin.forms
{
    partial class giatourform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.giatourpanel = new System.Windows.Forms.Panel();
            this.denngaydtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tungaydtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.giatournud = new System.Windows.Forms.NumericUpDown();
            this.tentcbb = new System.Windows.Forms.ComboBox();
            this.suagtbtn = new System.Windows.Forms.Button();
            this.endeditbtn = new System.Windows.Forms.Button();
            this.giatourdgv = new System.Windows.Forms.DataGridView();
            this.themgtbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.giatourpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giatournud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giatourdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // giatourpanel
            // 
            this.giatourpanel.Controls.Add(this.button1);
            this.giatourpanel.Controls.Add(this.denngaydtp);
            this.giatourpanel.Controls.Add(this.label4);
            this.giatourpanel.Controls.Add(this.tungaydtp);
            this.giatourpanel.Controls.Add(this.label3);
            this.giatourpanel.Controls.Add(this.giatournud);
            this.giatourpanel.Controls.Add(this.tentcbb);
            this.giatourpanel.Controls.Add(this.suagtbtn);
            this.giatourpanel.Controls.Add(this.endeditbtn);
            this.giatourpanel.Controls.Add(this.giatourdgv);
            this.giatourpanel.Controls.Add(this.themgtbtn);
            this.giatourpanel.Controls.Add(this.label2);
            this.giatourpanel.Controls.Add(this.label1);
            this.giatourpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giatourpanel.Location = new System.Drawing.Point(0, 0);
            this.giatourpanel.Name = "giatourpanel";
            this.giatourpanel.Size = new System.Drawing.Size(447, 470);
            this.giatourpanel.TabIndex = 1;
            // 
            // denngaydtp
            // 
            this.denngaydtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denngaydtp.Location = new System.Drawing.Point(134, 163);
            this.denngaydtp.Name = "denngaydtp";
            this.denngaydtp.Size = new System.Drawing.Size(207, 20);
            this.denngaydtp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đến ngày";
            // 
            // tungaydtp
            // 
            this.tungaydtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tungaydtp.Location = new System.Drawing.Point(134, 128);
            this.tungaydtp.Name = "tungaydtp";
            this.tungaydtp.Size = new System.Drawing.Size(207, 20);
            this.tungaydtp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Từ ngày";
            // 
            // giatournud
            // 
            this.giatournud.Location = new System.Drawing.Point(134, 95);
            this.giatournud.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.giatournud.Name = "giatournud";
            this.giatournud.Size = new System.Drawing.Size(207, 20);
            this.giatournud.TabIndex = 1;
            this.giatournud.ThousandsSeparator = true;
            // 
            // tentcbb
            // 
            this.tentcbb.FormattingEnabled = true;
            this.tentcbb.Location = new System.Drawing.Point(134, 60);
            this.tentcbb.Name = "tentcbb";
            this.tentcbb.Size = new System.Drawing.Size(207, 21);
            this.tentcbb.TabIndex = 0;
            // 
            // suagtbtn
            // 
            this.suagtbtn.Enabled = false;
            this.suagtbtn.Location = new System.Drawing.Point(266, 205);
            this.suagtbtn.Name = "suagtbtn";
            this.suagtbtn.Size = new System.Drawing.Size(75, 23);
            this.suagtbtn.TabIndex = 7;
            this.suagtbtn.Text = "Sửa";
            this.suagtbtn.UseVisualStyleBackColor = true;
            this.suagtbtn.Click += new System.EventHandler(this.suagtbtn_Click);
            // 
            // endeditbtn
            // 
            this.endeditbtn.Location = new System.Drawing.Point(309, 12);
            this.endeditbtn.Name = "endeditbtn";
            this.endeditbtn.Size = new System.Drawing.Size(120, 23);
            this.endeditbtn.TabIndex = 6;
            this.endeditbtn.Text = "End editing mode";
            this.endeditbtn.UseVisualStyleBackColor = true;
            this.endeditbtn.Visible = false;
            this.endeditbtn.Click += new System.EventHandler(this.endeditbtn_Click);
            // 
            // giatourdgv
            // 
            this.giatourdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.giatourdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giatourdgv.Location = new System.Drawing.Point(12, 244);
            this.giatourdgv.Name = "giatourdgv";
            this.giatourdgv.RowHeadersVisible = false;
            this.giatourdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.giatourdgv.Size = new System.Drawing.Size(417, 214);
            this.giatourdgv.TabIndex = 5;
            this.giatourdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.giatourdgv_CellMouseDoubleClick);
            // 
            // themgtbtn
            // 
            this.themgtbtn.Location = new System.Drawing.Point(175, 205);
            this.themgtbtn.Name = "themgtbtn";
            this.themgtbtn.Size = new System.Drawing.Size(75, 23);
            this.themgtbtn.TabIndex = 2;
            this.themgtbtn.Text = "Thêm";
            this.themgtbtn.UseVisualStyleBackColor = true;
            this.themgtbtn.Click += new System.EventHandler(this.themgtbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá tour";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Giá tour hiện tại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giatourform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 470);
            this.Controls.Add(this.giatourpanel);
            this.Name = "giatourform";
            this.Text = "giatourform";
            this.giatourpanel.ResumeLayout(false);
            this.giatourpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giatournud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giatourdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel giatourpanel;
        private System.Windows.Forms.ComboBox tentcbb;
        private System.Windows.Forms.Button suagtbtn;
        private System.Windows.Forms.Button endeditbtn;
        private System.Windows.Forms.DataGridView giatourdgv;
        private System.Windows.Forms.Button themgtbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker denngaydtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tungaydtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown giatournud;
        private System.Windows.Forms.Button button1;
    }
}