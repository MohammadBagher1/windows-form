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
            this.idTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.opiskelijanroTB = new System.Windows.Forms.TextBox();
            this.sahkopostiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallenaBT = new System.Windows.Forms.Button();
            this.paivittaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(166, 33);
            this.idTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(175, 39);
            this.idTB.TabIndex = 0;
            // 
            // etunimiTB
            // 
            this.etunimiTB.Location = new System.Drawing.Point(166, 82);
            this.etunimiTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(175, 39);
            this.etunimiTB.TabIndex = 1;
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.Location = new System.Drawing.Point(166, 131);
            this.sukunimiTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(175, 39);
            this.sukunimiTB.TabIndex = 2;
            // 
            // opiskelijanroTB
            // 
            this.opiskelijanroTB.Location = new System.Drawing.Point(602, 131);
            this.opiskelijanroTB.Margin = new System.Windows.Forms.Padding(5);
            this.opiskelijanroTB.Name = "opiskelijanroTB";
            this.opiskelijanroTB.Size = new System.Drawing.Size(175, 39);
            this.opiskelijanroTB.TabIndex = 5;
            // 
            // sahkopostiTB
            // 
            this.sahkopostiTB.Location = new System.Drawing.Point(602, 82);
            this.sahkopostiTB.Margin = new System.Windows.Forms.Padding(5);
            this.sahkopostiTB.Name = "sahkopostiTB";
            this.sahkopostiTB.Size = new System.Drawing.Size(175, 39);
            this.sahkopostiTB.TabIndex = 4;
            this.sahkopostiTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(602, 33);
            this.puhelinTB.Margin = new System.Windows.Forms.Padding(5);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(175, 39);
            this.puhelinTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "SUKUNIMI:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "PUHELIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "OPISKELIJANRO:";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(36, 204);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(186, 48);
            this.tyhjennaBT.TabIndex = 12;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // tallenaBT
            // 
            this.tallenaBT.Location = new System.Drawing.Point(228, 204);
            this.tallenaBT.Name = "tallenaBT";
            this.tallenaBT.Size = new System.Drawing.Size(186, 48);
            this.tallenaBT.TabIndex = 13;
            this.tallenaBT.Text = "TALLENNA";
            this.tallenaBT.UseVisualStyleBackColor = true;
            // 
            // paivittaBT
            // 
            this.paivittaBT.Location = new System.Drawing.Point(420, 204);
            this.paivittaBT.Name = "paivittaBT";
            this.paivittaBT.Size = new System.Drawing.Size(186, 48);
            this.paivittaBT.TabIndex = 14;
            this.paivittaBT.Text = "PÄIVITTÄ";
            this.paivittaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(612, 204);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(186, 48);
            this.poistaBT.TabIndex = 15;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 314);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.RowHeadersWidth = 62;
            this.TietotauluDG.RowTemplate.Height = 28;
            this.TietotauluDG.Size = new System.Drawing.Size(798, 238);
            this.TietotauluDG.TabIndex = 16;
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 577);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivittaBT);
            this.Controls.Add(this.tallenaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opiskelijanroTB);
            this.Controls.Add(this.sahkopostiTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.sukunimiTB);
            this.Controls.Add(this.etunimiTB);
            this.Controls.Add(this.idTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "YllapitoForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox etunimiTB;
        private System.Windows.Forms.TextBox sukunimiTB;
        private System.Windows.Forms.TextBox opiskelijanroTB;
        private System.Windows.Forms.TextBox sahkopostiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallenaBT;
        private System.Windows.Forms.Button paivittaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

