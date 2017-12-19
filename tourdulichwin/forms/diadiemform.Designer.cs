namespace tourdulichwin.forms
{
    partial class diadiemform
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
            this.diadiempanel = new System.Windows.Forms.Panel();
            this.tenttcbb = new System.Windows.Forms.ComboBox();
            this.suaddbtn = new System.Windows.Forms.Button();
            this.endeditbtn = new System.Windows.Forms.Button();
            this.tinhthanhdgv = new System.Windows.Forms.DataGridView();
            this.themddbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenddtxt = new System.Windows.Forms.TextBox();
            this.diadiempanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // diadiempanel
            // 
            this.diadiempanel.Controls.Add(this.tenttcbb);
            this.diadiempanel.Controls.Add(this.suaddbtn);
            this.diadiempanel.Controls.Add(this.endeditbtn);
            this.diadiempanel.Controls.Add(this.tinhthanhdgv);
            this.diadiempanel.Controls.Add(this.themddbtn);
            this.diadiempanel.Controls.Add(this.label2);
            this.diadiempanel.Controls.Add(this.label1);
            this.diadiempanel.Controls.Add(this.tenddtxt);
            this.diadiempanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diadiempanel.Location = new System.Drawing.Point(0, 0);
            this.diadiempanel.Name = "diadiempanel";
            this.diadiempanel.Size = new System.Drawing.Size(441, 456);
            this.diadiempanel.TabIndex = 0;
            // 
            // tenttcbb
            // 
            this.tenttcbb.FormattingEnabled = true;
            this.tenttcbb.Location = new System.Drawing.Point(134, 115);
            this.tenttcbb.Name = "tenttcbb";
            this.tenttcbb.Size = new System.Drawing.Size(207, 21);
            this.tenttcbb.TabIndex = 1;
            // 
            // suaddbtn
            // 
            this.suaddbtn.Enabled = false;
            this.suaddbtn.Location = new System.Drawing.Point(266, 165);
            this.suaddbtn.Name = "suaddbtn";
            this.suaddbtn.Size = new System.Drawing.Size(75, 23);
            this.suaddbtn.TabIndex = 7;
            this.suaddbtn.Text = "Sửa";
            this.suaddbtn.UseVisualStyleBackColor = true;
            this.suaddbtn.Click += new System.EventHandler(this.suaddbtn_Click);
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
            // tinhthanhdgv
            // 
            this.tinhthanhdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tinhthanhdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tinhthanhdgv.Location = new System.Drawing.Point(59, 251);
            this.tinhthanhdgv.Name = "tinhthanhdgv";
            this.tinhthanhdgv.RowHeadersVisible = false;
            this.tinhthanhdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tinhthanhdgv.Size = new System.Drawing.Size(329, 163);
            this.tinhthanhdgv.TabIndex = 5;
            this.tinhthanhdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.diadiemdgv_CellMouseDoubleClick);
            // 
            // themddbtn
            // 
            this.themddbtn.Location = new System.Drawing.Point(179, 165);
            this.themddbtn.Name = "themddbtn";
            this.themddbtn.Size = new System.Drawing.Size(75, 23);
            this.themddbtn.TabIndex = 2;
            this.themddbtn.Text = "Thêm";
            this.themddbtn.UseVisualStyleBackColor = true;
            this.themddbtn.Click += new System.EventHandler(this.themddbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tỉnh thành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên địa điểm";
            // 
            // tenddtxt
            // 
            this.tenddtxt.Location = new System.Drawing.Point(134, 75);
            this.tenddtxt.Name = "tenddtxt";
            this.tenddtxt.Size = new System.Drawing.Size(207, 20);
            this.tenddtxt.TabIndex = 0;
            // 
            // diadiemform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 456);
            this.Controls.Add(this.diadiempanel);
            this.Name = "diadiemform";
            this.Text = "diadiemform";
            this.diadiempanel.ResumeLayout(false);
            this.diadiempanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel diadiempanel;
        private System.Windows.Forms.DataGridView tinhthanhdgv;
        private System.Windows.Forms.Button themddbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenddtxt;
        private System.Windows.Forms.Button suaddbtn;
        private System.Windows.Forms.Button endeditbtn;
        private System.Windows.Forms.ComboBox tenttcbb;
    }
}