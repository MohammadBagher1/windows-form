﻿namespace harjoitus_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.TulostusLB = new System.Windows.Forms.Label();
            this.TulostaBT = new System.Windows.Forms.Button();
            this.ViestiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(134, 128);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(435, 51);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            this.TulostusLB.AutoSize = true;
            this.TulostusLB.Location = new System.Drawing.Point(176, 238);
            this.TulostusLB.Name = "TulostusLB";
            this.TulostusLB.Size = new System.Drawing.Size(111, 51);
            this.TulostusLB.TabIndex = 1;
            this.TulostusLB.Text = "xxxx";
            // 
            // TulostaBT
            // 
            this.TulostaBT.BackColor = System.Drawing.Color.Gray;
            this.TulostaBT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TulostaBT.Location = new System.Drawing.Point(640, 307);
            this.TulostaBT.Name = "TulostaBT";
            this.TulostaBT.Size = new System.Drawing.Size(152, 34);
            this.TulostaBT.TabIndex = 2;
            this.TulostaBT.Text = "tulosta teksti";
            this.TulostaBT.UseVisualStyleBackColor = false;
            this.TulostaBT.Click += new System.EventHandler(this.TulostaBT_Click);
            // 
            // ViestiTB
            // 
            this.ViestiTB.Location = new System.Drawing.Point(659, 121);
            this.ViestiTB.Name = "ViestiTB";
            this.ViestiTB.Size = new System.Drawing.Size(245, 58);
            this.ViestiTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1760, 918);
            this.Controls.Add(this.ViestiTB);
            this.Controls.Add(this.TulostaBT);
            this.Controls.Add(this.TulostusLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private Button TulostaBT;
        private TextBox ViestiTB;
    }
}