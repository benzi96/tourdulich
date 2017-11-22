namespace tourdulichwin.forms
{
    partial class tourform
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
            this.tourpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ddtxt = new System.Windows.Forms.TextBox();
            this.tenlhcbb = new System.Windows.Forms.ComboBox();
            this.suatbtn = new System.Windows.Forms.Button();
            this.endeditbtn = new System.Windows.Forms.Button();
            this.tourdgv = new System.Windows.Forms.DataGridView();
            this.themtbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenttxt = new System.Windows.Forms.TextBox();
            this.tourpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tourpanel
            // 
            this.tourpanel.Controls.Add(this.label3);
            this.tourpanel.Controls.Add(this.ddtxt);
            this.tourpanel.Controls.Add(this.tenlhcbb);
            this.tourpanel.Controls.Add(this.suatbtn);
            this.tourpanel.Controls.Add(this.endeditbtn);
            this.tourpanel.Controls.Add(this.tourdgv);
            this.tourpanel.Controls.Add(this.themtbtn);
            this.tourpanel.Controls.Add(this.label2);
            this.tourpanel.Controls.Add(this.label1);
            this.tourpanel.Controls.Add(this.tenttxt);
            this.tourpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourpanel.Location = new System.Drawing.Point(0, 0);
            this.tourpanel.Name = "tourpanel";
            this.tourpanel.Size = new System.Drawing.Size(451, 472);
            this.tourpanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đặc điểm";
            // 
            // ddtxt
            // 
            this.ddtxt.Location = new System.Drawing.Point(134, 111);
            this.ddtxt.Name = "ddtxt";
            this.ddtxt.Size = new System.Drawing.Size(207, 20);
            this.ddtxt.TabIndex = 1;
            // 
            // tenlhcbb
            // 
            this.tenlhcbb.FormattingEnabled = true;
            this.tenlhcbb.Location = new System.Drawing.Point(134, 148);
            this.tenlhcbb.Name = "tenlhcbb";
            this.tenlhcbb.Size = new System.Drawing.Size(207, 21);
            this.tenlhcbb.TabIndex = 2;
            // 
            // suatbtn
            // 
            this.suatbtn.Enabled = false;
            this.suatbtn.Location = new System.Drawing.Point(266, 188);
            this.suatbtn.Name = "suatbtn";
            this.suatbtn.Size = new System.Drawing.Size(75, 23);
            this.suatbtn.TabIndex = 7;
            this.suatbtn.Text = "Sửa";
            this.suatbtn.UseVisualStyleBackColor = true;
            this.suatbtn.Click += new System.EventHandler(this.suatbtn_Click);
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
            // tourdgv
            // 
            this.tourdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tourdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourdgv.Location = new System.Drawing.Point(12, 251);
            this.tourdgv.Name = "tourdgv";
            this.tourdgv.RowHeadersVisible = false;
            this.tourdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tourdgv.Size = new System.Drawing.Size(427, 198);
            this.tourdgv.TabIndex = 5;
            this.tourdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tourdgv_CellMouseDoubleClick);
            // 
            // themtbtn
            // 
            this.themtbtn.Location = new System.Drawing.Point(176, 188);
            this.themtbtn.Name = "themtbtn";
            this.themtbtn.Size = new System.Drawing.Size(75, 23);
            this.themtbtn.TabIndex = 4;
            this.themtbtn.Text = "Thêm";
            this.themtbtn.UseVisualStyleBackColor = true;
            this.themtbtn.Click += new System.EventHandler(this.themtbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại hình du lịch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tour";
            // 
            // tenttxt
            // 
            this.tenttxt.Location = new System.Drawing.Point(134, 75);
            this.tenttxt.Name = "tenttxt";
            this.tenttxt.Size = new System.Drawing.Size(207, 20);
            this.tenttxt.TabIndex = 0;
            // 
            // tourform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 472);
            this.Controls.Add(this.tourpanel);
            this.Name = "tourform";
            this.Text = "tourform";
            this.tourpanel.ResumeLayout(false);
            this.tourpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tourpanel;
        private System.Windows.Forms.ComboBox tenlhcbb;
        private System.Windows.Forms.Button suatbtn;
        private System.Windows.Forms.Button endeditbtn;
        private System.Windows.Forms.DataGridView tourdgv;
        private System.Windows.Forms.Button themtbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ddtxt;
    }
}