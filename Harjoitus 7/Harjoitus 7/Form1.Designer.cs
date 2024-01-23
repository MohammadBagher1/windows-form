namespace Harjoitus_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteTB = new System.Windows.Forms.TextBox();
            this.VakutusTB = new System.Windows.Forms.TextBox();
            this.PoltonesteTB = new System.Windows.Forms.TextBox();
            this.MuutkulutTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RenkatTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.VuosiKMTB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoinen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "lisätävät nesteet yms:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakutusmaksut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muut kulut :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poltoneste :";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(383, 136);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(150, 29);
            this.LainaTB.TabIndex = 6;
            // 
            // NesteTB
            // 
            this.NesteTB.Location = new System.Drawing.Point(383, 182);
            this.NesteTB.Name = "NesteTB";
            this.NesteTB.Size = new System.Drawing.Size(150, 29);
            this.NesteTB.TabIndex = 7;
            // 
            // VakutusTB
            // 
            this.VakutusTB.Location = new System.Drawing.Point(383, 223);
            this.VakutusTB.Name = "VakutusTB";
            this.VakutusTB.Size = new System.Drawing.Size(150, 29);
            this.VakutusTB.TabIndex = 8;
            // 
            // PoltonesteTB
            // 
            this.PoltonesteTB.Location = new System.Drawing.Point(383, 302);
            this.PoltonesteTB.Name = "PoltonesteTB";
            this.PoltonesteTB.Size = new System.Drawing.Size(150, 29);
            this.PoltonesteTB.TabIndex = 9;
            // 
            // MuutkulutTB
            // 
            this.MuutkulutTB.Location = new System.Drawing.Point(383, 263);
            this.MuutkulutTB.Name = "MuutkulutTB";
            this.MuutkulutTB.Size = new System.Drawing.Size(150, 29);
            this.MuutkulutTB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kilometrit / vuosi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Renkat :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Huollot :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Pesut :";
            // 
            // RenkatTB
            // 
            this.RenkatTB.Location = new System.Drawing.Point(754, 223);
            this.RenkatTB.Name = "RenkatTB";
            this.RenkatTB.Size = new System.Drawing.Size(150, 29);
            this.RenkatTB.TabIndex = 17;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(754, 182);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(150, 29);
            this.HuollotTB.TabIndex = 16;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(754, 136);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(150, 29);
            this.PesutTB.TabIndex = 15;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(89, 378);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(44, 18);
            this.VastausLB.TabIndex = 19;
            this.VastausLB.Text = "xxxx";
            this.VastausLB.Visible = false;
            // 
            // VuosiKMTB
            // 
            this.VuosiKMTB.FormattingEnabled = true;
            this.VuosiKMTB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "85000",
            "90000",
            "95000",
            "100000."});
            this.VuosiKMTB.Location = new System.Drawing.Point(754, 266);
            this.VuosiKMTB.Name = "VuosiKMTB";
            this.VuosiKMTB.Size = new System.Drawing.Size(182, 26);
            this.VuosiKMTB.TabIndex = 20;
            this.VuosiKMTB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 521);
            this.Controls.Add(this.VuosiKMTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.RenkatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MuutkulutTB);
            this.Controls.Add(this.PoltonesteTB);
            this.Controls.Add(this.VakutusTB);
            this.Controls.Add(this.NesteTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox LainaTB;
        private TextBox NesteTB;
        private TextBox VakutusTB;
        private TextBox PoltonesteTB;
        private TextBox MuutkulutTB;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox RenkatTB;
        private TextBox HuollotTB;
        private TextBox PesutTB;
        private Label VastausLB;
        private ComboBox VuosiKMTB;
    }
}