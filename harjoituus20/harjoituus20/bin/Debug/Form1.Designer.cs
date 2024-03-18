namespace CRUDNET
{
    partial class YllapitoForm
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
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.TallenaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(192, 5);
            this.enimiTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(186, 39);
            this.enimiTB.TabIndex = 0;
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(192, 56);
            this.puhTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(186, 39);
            this.puhTB.TabIndex = 1;
            // 
            // oNroTB
            // 
            this.oNroTB.Location = new System.Drawing.Point(192, 112);
            this.oNroTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(186, 39);
            this.oNroTB.TabIndex = 2;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(690, 5);
            this.snimiTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(186, 39);
            this.snimiTB.TabIndex = 3;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(690, 54);
            this.emailTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(186, 39);
            this.emailTB.TabIndex = 4;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(690, 105);
            this.idTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(186, 39);
            this.idTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "ETUNIMI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "SÄHKÖPOSTI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "OPISKELIJANRO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "PUHELIN:";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(206, 192);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(153, 41);
            this.tyhjennaBT.TabIndex = 15;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(523, 192);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(123, 41);
            this.paivitaBT.TabIndex = 16;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            // 
            // TallenaBT
            // 
            this.TallenaBT.Location = new System.Drawing.Point(366, 192);
            this.TallenaBT.Name = "TallenaBT";
            this.TallenaBT.Size = new System.Drawing.Size(151, 41);
            this.TallenaBT.TabIndex = 17;
            this.TallenaBT.Text = "Tallenna";
            this.TallenaBT.UseVisualStyleBackColor = true;
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(652, 192);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(123, 41);
            this.PoistaBT.TabIndex = 18;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(0, 239);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.RowHeadersWidth = 62;
            this.TietotauluDG.RowTemplate.Height = 28;
            this.TietotauluDG.Size = new System.Drawing.Size(1084, 286);
            this.TietotauluDG.TabIndex = 19;
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 521);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.TallenaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.enimiTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "YllapitoForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button TallenaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

