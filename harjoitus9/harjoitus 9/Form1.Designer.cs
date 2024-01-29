namespace harjoitus_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.buttonBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.BoxGB = new System.Windows.Forms.GroupBox();
            this.CelciusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.BoxGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "anna asteet: ";
            // 
            // numeroTB
            // 
            this.numeroTB.Location = new System.Drawing.Point(336, 152);
            this.numeroTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(74, 45);
            this.numeroTB.TabIndex = 1;
            // 
            // buttonBT
            // 
            this.buttonBT.Location = new System.Drawing.Point(792, 149);
            this.buttonBT.Name = "buttonBT";
            this.buttonBT.Size = new System.Drawing.Size(112, 51);
            this.buttonBT.TabIndex = 3;
            this.buttonBT.Text = "button1";
            this.buttonBT.UseVisualStyleBackColor = true;
            this.buttonBT.Click += new System.EventHandler(this.buttonBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(146, 359);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(121, 38);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "vastaus: ";
            this.VastausLB.Visible = false;
            this.VastausLB.Click += new System.EventHandler(this.VastausLB_Click);
            // 
            // BoxGB
            // 
            this.BoxGB.Controls.Add(this.FahrenheitRB);
            this.BoxGB.Controls.Add(this.CelciusRB);
            this.BoxGB.Location = new System.Drawing.Point(463, 152);
            this.BoxGB.Name = "BoxGB";
            this.BoxGB.Size = new System.Drawing.Size(257, 145);
            this.BoxGB.TabIndex = 5;
            this.BoxGB.TabStop = false;
            this.BoxGB.Text = "Miteen muunnat?";
            this.BoxGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CelciusRB
            // 
            this.CelciusRB.AutoSize = true;
            this.CelciusRB.Location = new System.Drawing.Point(23, 46);
            this.CelciusRB.Name = "CelciusRB";
            this.CelciusRB.Size = new System.Drawing.Size(128, 42);
            this.CelciusRB.TabIndex = 0;
            this.CelciusRB.TabStop = true;
            this.CelciusRB.Text = "Celsius";
            this.CelciusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(23, 94);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(173, 42);
            this.FahrenheitRB.TabIndex = 1;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 684);
            this.Controls.Add(this.BoxGB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.buttonBT);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BoxGB.ResumeLayout(false);
            this.BoxGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox numeroTB;
        private Button buttonBT;
        private Label VastausLB;
        private GroupBox BoxGB;
        private RadioButton FahrenheitRB;
        private RadioButton CelciusRB;
    }
}