namespace harjoitus_12
{
    partial class Form1
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.OptionGB = new System.Windows.Forms.GroupBox();
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.VastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausDRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.OptionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(47, 39);
            this.KysymysLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(261, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaa 1. kysymyksen: ";
            // 
            // OptionGB
            // 
            this.OptionGB.Controls.Add(this.VastausDRB);
            this.OptionGB.Controls.Add(this.VastausCRB);
            this.OptionGB.Controls.Add(this.VastausBRB);
            this.OptionGB.Controls.Add(this.VastausARB);
            this.OptionGB.Location = new System.Drawing.Point(426, 39);
            this.OptionGB.Name = "OptionGB";
            this.OptionGB.Size = new System.Drawing.Size(110, 206);
            this.OptionGB.TabIndex = 1;
            this.OptionGB.TabStop = false;
            this.OptionGB.Text = "Vasta: ";
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(19, 56);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(59, 29);
            this.VastausARB.TabIndex = 0;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A. ";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            this.VastausBRB.AutoSize = true;
            this.VastausBRB.Location = new System.Drawing.Point(19, 91);
            this.VastausBRB.Name = "VastausBRB";
            this.VastausBRB.Size = new System.Drawing.Size(59, 29);
            this.VastausBRB.TabIndex = 1;
            this.VastausBRB.TabStop = true;
            this.VastausBRB.Text = "B. ";
            this.VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            this.VastausCRB.AutoSize = true;
            this.VastausCRB.Location = new System.Drawing.Point(19, 126);
            this.VastausCRB.Name = "VastausCRB";
            this.VastausCRB.Size = new System.Drawing.Size(60, 29);
            this.VastausCRB.TabIndex = 2;
            this.VastausCRB.TabStop = true;
            this.VastausCRB.Text = "C. ";
            this.VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausDRB
            // 
            this.VastausDRB.AutoSize = true;
            this.VastausDRB.Location = new System.Drawing.Point(19, 161);
            this.VastausDRB.Name = "VastausDRB";
            this.VastausDRB.Size = new System.Drawing.Size(60, 29);
            this.VastausDRB.TabIndex = 3;
            this.VastausDRB.TabStop = true;
            this.VastausDRB.Text = "D. ";
            this.VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(47, 257);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(97, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            this.VastausLB.Click += new System.EventHandler(this.VastausLB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 376);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.OptionGB);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OptionGB.ResumeLayout(false);
            this.OptionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.GroupBox OptionGB;
        private System.Windows.Forms.RadioButton VastausDRB;
        private System.Windows.Forms.RadioButton VastausCRB;
        private System.Windows.Forms.RadioButton VastausBRB;
        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.Label VastausLB;
    }
}

