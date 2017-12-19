namespace tourdulichwin.forms
{
    partial class menu
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
            this.ttmenubtn = new System.Windows.Forms.Button();
            this.loaihinhmenubtn = new System.Windows.Forms.Button();
            this.ddmenubtn = new System.Windows.Forms.Button();
            this.tourmenubtn = new System.Windows.Forms.Button();
            this.giatourmenubtn = new System.Windows.Forms.Button();
            this.ctdtqmenubtn = new System.Windows.Forms.Button();
            this.tktourmenubtn = new System.Windows.Forms.Button();
            this.thhdctmenubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttmenubtn
            // 
            this.ttmenubtn.Location = new System.Drawing.Point(45, 49);
            this.ttmenubtn.Name = "ttmenubtn";
            this.ttmenubtn.Size = new System.Drawing.Size(174, 23);
            this.ttmenubtn.TabIndex = 0;
            this.ttmenubtn.Text = "Tỉnh thành";
            this.ttmenubtn.UseVisualStyleBackColor = true;
            this.ttmenubtn.Click += new System.EventHandler(this.ttmenubtn_Click);
            // 
            // loaihinhmenubtn
            // 
            this.loaihinhmenubtn.Location = new System.Drawing.Point(45, 97);
            this.loaihinhmenubtn.Name = "loaihinhmenubtn";
            this.loaihinhmenubtn.Size = new System.Drawing.Size(174, 23);
            this.loaihinhmenubtn.TabIndex = 1;
            this.loaihinhmenubtn.Text = "Loại hình du lịch";
            this.loaihinhmenubtn.UseVisualStyleBackColor = true;
            this.loaihinhmenubtn.Click += new System.EventHandler(this.loaihinhmenubtn_Click);
            // 
            // ddmenubtn
            // 
            this.ddmenubtn.Location = new System.Drawing.Point(45, 142);
            this.ddmenubtn.Name = "ddmenubtn";
            this.ddmenubtn.Size = new System.Drawing.Size(174, 23);
            this.ddmenubtn.TabIndex = 2;
            this.ddmenubtn.Text = "Địa điểm";
            this.ddmenubtn.UseVisualStyleBackColor = true;
            this.ddmenubtn.Click += new System.EventHandler(this.ddmenubtn_Click);
            // 
            // tourmenubtn
            // 
            this.tourmenubtn.Location = new System.Drawing.Point(45, 189);
            this.tourmenubtn.Name = "tourmenubtn";
            this.tourmenubtn.Size = new System.Drawing.Size(174, 23);
            this.tourmenubtn.TabIndex = 3;
            this.tourmenubtn.Text = "Tour";
            this.tourmenubtn.UseVisualStyleBackColor = true;
            this.tourmenubtn.Click += new System.EventHandler(this.tourmenubtn_Click);
            // 
            // giatourmenubtn
            // 
            this.giatourmenubtn.Location = new System.Drawing.Point(45, 236);
            this.giatourmenubtn.Name = "giatourmenubtn";
            this.giatourmenubtn.Size = new System.Drawing.Size(174, 23);
            this.giatourmenubtn.TabIndex = 4;
            this.giatourmenubtn.Text = "Giá tour";
            this.giatourmenubtn.UseVisualStyleBackColor = true;
            this.giatourmenubtn.Click += new System.EventHandler(this.giatourmenubtn_Click);
            // 
            // ctdtqmenubtn
            // 
            this.ctdtqmenubtn.Location = new System.Drawing.Point(45, 284);
            this.ctdtqmenubtn.Name = "ctdtqmenubtn";
            this.ctdtqmenubtn.Size = new System.Drawing.Size(174, 23);
            this.ctdtqmenubtn.TabIndex = 5;
            this.ctdtqmenubtn.Text = "Chi tiết diểm tham quan";
            this.ctdtqmenubtn.UseVisualStyleBackColor = true;
            this.ctdtqmenubtn.Click += new System.EventHandler(this.ctdtqmenubtn_Click);
            // 
            // tktourmenubtn
            // 
            this.tktourmenubtn.Location = new System.Drawing.Point(45, 329);
            this.tktourmenubtn.Name = "tktourmenubtn";
            this.tktourmenubtn.Size = new System.Drawing.Size(174, 23);
            this.tktourmenubtn.TabIndex = 6;
            this.tktourmenubtn.Text = "Thống kê tour";
            this.tktourmenubtn.UseVisualStyleBackColor = true;
            this.tktourmenubtn.Click += new System.EventHandler(this.tktourmenubtn_Click);
            // 
            // thhdctmenubtn
            // 
            this.thhdctmenubtn.Location = new System.Drawing.Point(45, 372);
            this.thhdctmenubtn.Name = "thhdctmenubtn";
            this.thhdctmenubtn.Size = new System.Drawing.Size(174, 23);
            this.thhdctmenubtn.TabIndex = 7;
            this.thhdctmenubtn.Text = "Tình hình hoạt động của tour";
            this.thhdctmenubtn.UseVisualStyleBackColor = true;
            this.thhdctmenubtn.Click += new System.EventHandler(this.thhdctmenubtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 420);
            this.Controls.Add(this.thhdctmenubtn);
            this.Controls.Add(this.tktourmenubtn);
            this.Controls.Add(this.ctdtqmenubtn);
            this.Controls.Add(this.giatourmenubtn);
            this.Controls.Add(this.tourmenubtn);
            this.Controls.Add(this.ddmenubtn);
            this.Controls.Add(this.loaihinhmenubtn);
            this.Controls.Add(this.ttmenubtn);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ttmenubtn;
        private System.Windows.Forms.Button loaihinhmenubtn;
        private System.Windows.Forms.Button ddmenubtn;
        private System.Windows.Forms.Button tourmenubtn;
        private System.Windows.Forms.Button giatourmenubtn;
        private System.Windows.Forms.Button ctdtqmenubtn;
        private System.Windows.Forms.Button tktourmenubtn;
        private System.Windows.Forms.Button thhdctmenubtn;
    }
}