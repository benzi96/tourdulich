namespace tourdulichwin.forms
{
    partial class loaihinhdulichform
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
            this.loaihinhpanel = new System.Windows.Forms.Panel();
            this.sualhbtn = new System.Windows.Forms.Button();
            this.endeditbtn = new System.Windows.Forms.Button();
            this.loaihinhdulichdgv = new System.Windows.Forms.DataGridView();
            this.themlhbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tenlhtxt = new System.Windows.Forms.TextBox();
            this.loaihinhpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaihinhdulichdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // loaihinhpanel
            // 
            this.loaihinhpanel.Controls.Add(this.sualhbtn);
            this.loaihinhpanel.Controls.Add(this.endeditbtn);
            this.loaihinhpanel.Controls.Add(this.loaihinhdulichdgv);
            this.loaihinhpanel.Controls.Add(this.themlhbtn);
            this.loaihinhpanel.Controls.Add(this.label2);
            this.loaihinhpanel.Controls.Add(this.tenlhtxt);
            this.loaihinhpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaihinhpanel.Location = new System.Drawing.Point(0, 0);
            this.loaihinhpanel.Name = "loaihinhpanel";
            this.loaihinhpanel.Size = new System.Drawing.Size(438, 451);
            this.loaihinhpanel.TabIndex = 1;
            // 
            // sualhbtn
            // 
            this.sualhbtn.Enabled = false;
            this.sualhbtn.Location = new System.Drawing.Point(266, 138);
            this.sualhbtn.Name = "sualhbtn";
            this.sualhbtn.Size = new System.Drawing.Size(75, 23);
            this.sualhbtn.TabIndex = 7;
            this.sualhbtn.Text = "Sửa";
            this.sualhbtn.UseVisualStyleBackColor = true;
            this.sualhbtn.Click += new System.EventHandler(this.sualhbtn_Click);
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
            // loaihinhdulichdgv
            // 
            this.loaihinhdulichdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loaihinhdulichdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaihinhdulichdgv.Location = new System.Drawing.Point(59, 251);
            this.loaihinhdulichdgv.Name = "loaihinhdulichdgv";
            this.loaihinhdulichdgv.RowHeadersVisible = false;
            this.loaihinhdulichdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loaihinhdulichdgv.Size = new System.Drawing.Size(282, 163);
            this.loaihinhdulichdgv.TabIndex = 5;
            this.loaihinhdulichdgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.loaihinhdulichdgv_CellMouseDoubleClick);
            // 
            // themlhbtn
            // 
            this.themlhbtn.Location = new System.Drawing.Point(179, 138);
            this.themlhbtn.Name = "themlhbtn";
            this.themlhbtn.Size = new System.Drawing.Size(75, 23);
            this.themlhbtn.TabIndex = 2;
            this.themlhbtn.Text = "Thêm";
            this.themlhbtn.UseVisualStyleBackColor = true;
            this.themlhbtn.Click += new System.EventHandler(this.themlhbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại hình du lịch";
            // 
            // tenlhtxt
            // 
            this.tenlhtxt.Location = new System.Drawing.Point(134, 94);
            this.tenlhtxt.Name = "tenlhtxt";
            this.tenlhtxt.Size = new System.Drawing.Size(207, 20);
            this.tenlhtxt.TabIndex = 0;
            // 
            // loaihinhdulichform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 451);
            this.Controls.Add(this.loaihinhpanel);
            this.Name = "loaihinhdulichform";
            this.Text = "loaihinhdulichform";
            this.loaihinhpanel.ResumeLayout(false);
            this.loaihinhpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaihinhdulichdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loaihinhpanel;
        private System.Windows.Forms.Button sualhbtn;
        private System.Windows.Forms.Button endeditbtn;
        private System.Windows.Forms.DataGridView loaihinhdulichdgv;
        private System.Windows.Forms.Button themlhbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenlhtxt;
    }
}