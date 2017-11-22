namespace tourdulichwin.forms
{
    partial class tinhthanhform
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
            this.tinhthanhpanel = new System.Windows.Forms.Panel();
            this.tinhthanhdgv = new System.Windows.Forms.DataGridView();
            this.themttbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tentttxt = new System.Windows.Forms.TextBox();
            this.matttxt = new System.Windows.Forms.TextBox();
            this.endeditbtn = new System.Windows.Forms.Button();
            this.suattbtn = new System.Windows.Forms.Button();
            this.tinhthanhpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tinhthanhpanel
            // 
            this.tinhthanhpanel.Controls.Add(this.suattbtn);
            this.tinhthanhpanel.Controls.Add(this.endeditbtn);
            this.tinhthanhpanel.Controls.Add(this.tinhthanhdgv);
            this.tinhthanhpanel.Controls.Add(this.themttbtn);
            this.tinhthanhpanel.Controls.Add(this.label2);
            this.tinhthanhpanel.Controls.Add(this.label1);
            this.tinhthanhpanel.Controls.Add(this.tentttxt);
            this.tinhthanhpanel.Controls.Add(this.matttxt);
            this.tinhthanhpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhthanhpanel.Location = new System.Drawing.Point(0, 0);
            this.tinhthanhpanel.Name = "tinhthanhpanel";
            this.tinhthanhpanel.Size = new System.Drawing.Size(441, 456);
            this.tinhthanhpanel.TabIndex = 0;
            // 
            // tinhthanhdgv
            // 
            this.tinhthanhdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tinhthanhdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tinhthanhdgv.Location = new System.Drawing.Point(59, 251);
            this.tinhthanhdgv.Name = "tinhthanhdgv";
            this.tinhthanhdgv.RowHeadersVisible = false;
            this.tinhthanhdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tinhthanhdgv.Size = new System.Drawing.Size(282, 163);
            this.tinhthanhdgv.TabIndex = 5;
            this.tinhthanhdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tinhthanhdgv_CellMouseDoubleClick);
            // 
            // themttbtn
            // 
            this.themttbtn.Location = new System.Drawing.Point(179, 165);
            this.themttbtn.Name = "themttbtn";
            this.themttbtn.Size = new System.Drawing.Size(75, 23);
            this.themttbtn.TabIndex = 2;
            this.themttbtn.Text = "Thêm";
            this.themttbtn.UseVisualStyleBackColor = true;
            this.themttbtn.Click += new System.EventHandler(this.themttbtn_Click);
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
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã tỉnh thành";
            // 
            // tentttxt
            // 
            this.tentttxt.Location = new System.Drawing.Point(134, 121);
            this.tentttxt.Name = "tentttxt";
            this.tentttxt.Size = new System.Drawing.Size(207, 20);
            this.tentttxt.TabIndex = 1;
            // 
            // matttxt
            // 
            this.matttxt.Location = new System.Drawing.Point(134, 75);
            this.matttxt.Name = "matttxt";
            this.matttxt.Size = new System.Drawing.Size(207, 20);
            this.matttxt.TabIndex = 0;
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
            // suattbtn
            // 
            this.suattbtn.Enabled = false;
            this.suattbtn.Location = new System.Drawing.Point(266, 165);
            this.suattbtn.Name = "suattbtn";
            this.suattbtn.Size = new System.Drawing.Size(75, 23);
            this.suattbtn.TabIndex = 7;
            this.suattbtn.Text = "Sửa";
            this.suattbtn.UseVisualStyleBackColor = true;
            this.suattbtn.Click += new System.EventHandler(this.suattbtn_Click);
            // 
            // tinhthanhform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 456);
            this.Controls.Add(this.tinhthanhpanel);
            this.Name = "tinhthanhform";
            this.Text = "tinhthanhform";
            this.tinhthanhpanel.ResumeLayout(false);
            this.tinhthanhpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tinhthanhpanel;
        private System.Windows.Forms.DataGridView tinhthanhdgv;
        private System.Windows.Forms.Button themttbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tentttxt;
        private System.Windows.Forms.TextBox matttxt;
        private System.Windows.Forms.Button suattbtn;
        private System.Windows.Forms.Button endeditbtn;
    }
}