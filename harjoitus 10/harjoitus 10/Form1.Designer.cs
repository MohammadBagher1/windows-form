namespace harjoitus_10
{
    partial class BMIForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.buttonBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TulosLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus: ";
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(280, 50);
            this.PainoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(223, 45);
            this.PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(280, 131);
            this.PituusTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(223, 45);
            this.PituusTB.TabIndex = 3;
            // 
            // buttonBT
            // 
            this.buttonBT.BackColor = System.Drawing.Color.LightBlue;
            this.buttonBT.Location = new System.Drawing.Point(49, 231);
            this.buttonBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBT.Name = "buttonBT";
            this.buttonBT.Size = new System.Drawing.Size(456, 65);
            this.buttonBT.TabIndex = 4;
            this.buttonBT.Text = "Laske painoindeksi";
            this.buttonBT.UseVisualStyleBackColor = false;
            this.buttonBT.Click += new System.EventHandler(this.buttonBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(60, 330);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(123, 38);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus: ";
            this.VastausLB.Visible = false;
            // 
            // TulosLB
            // 
            this.TulosLB.AutoSize = true;
            this.TulosLB.Location = new System.Drawing.Point(60, 389);
            this.TulosLB.Name = "TulosLB";
            this.TulosLB.Size = new System.Drawing.Size(97, 38);
            this.TulosLB.TabIndex = 6;
            this.TulosLB.Text = "Tulos: ";
            this.TulosLB.Visible = false;
            this.TulosLB.Click += new System.EventHandler(this.TulosLB_Click);
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(767, 463);
            this.Controls.Add(this.TulosLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.buttonBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BMIForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button buttonBT;
        private Label VastausLB;
        private Label TulosLB;
    }
}