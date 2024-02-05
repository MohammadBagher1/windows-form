namespace Harjoitus18
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostiNumeroLB = new System.Windows.Forms.Label();
            this.PostimapaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(18, 14);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(711, 74);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse oppilaitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse vastuuhenkilö";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(13, 168);
            this.OppilaitosCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(271, 46);
            this.OppilaitosCB.TabIndex = 3;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // VastuhenkiloCB
            // 
            this.VastuhenkiloCB.FormattingEnabled = true;
            this.VastuhenkiloCB.Location = new System.Drawing.Point(454, 172);
            this.VastuhenkiloCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VastuhenkiloCB.Name = "VastuhenkiloCB";
            this.VastuhenkiloCB.Size = new System.Drawing.Size(271, 46);
            this.VastuhenkiloCB.TabIndex = 4;
            this.VastuhenkiloCB.SelectedIndexChanged += new System.EventHandler(this.VastuhenkiloCB_SelectedIndexChanged);
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(13, 251);
            this.OsoiteLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(92, 38);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "osoite";
            // 
            // PostiNumeroLB
            // 
            this.PostiNumeroLB.AutoSize = true;
            this.PostiNumeroLB.Location = new System.Drawing.Point(13, 327);
            this.PostiNumeroLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostiNumeroLB.Name = "PostiNumeroLB";
            this.PostiNumeroLB.Size = new System.Drawing.Size(173, 38);
            this.PostiNumeroLB.TabIndex = 6;
            this.PostiNumeroLB.Text = "Postinumero";
            // 
            // PostimapaikkaLB
            // 
            this.PostimapaikkaLB.AutoSize = true;
            this.PostimapaikkaLB.Location = new System.Drawing.Point(13, 397);
            this.PostimapaikkaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostimapaikkaLB.Name = "PostimapaikkaLB";
            this.PostimapaikkaLB.Size = new System.Drawing.Size(193, 38);
            this.PostimapaikkaLB.TabIndex = 7;
            this.PostimapaikkaLB.Text = "Postimapaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(13, 468);
            this.PuhelinLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(110, 38);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puhelin";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Location = new System.Drawing.Point(454, 397);
            this.SahkopostiLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(152, 38);
            this.SahkopostiLB.TabIndex = 11;
            this.SahkopostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(454, 327);
            this.OsastoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(101, 38);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(454, 251);
            this.TitteliLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(86, 38);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostimapaikkaLB);
            this.Controls.Add(this.PostiNumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.VastuhenkiloCB);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label label1;
        private Label label2;
        private ComboBox OppilaitosCB;
        private ComboBox VastuhenkiloCB;
        private Label OsoiteLB;
        private Label PostiNumeroLB;
        private Label PostimapaikkaLB;
        private Label PuhelinLB;
        private Label label3;
        private Label SahkopostiLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}