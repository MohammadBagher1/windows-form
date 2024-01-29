namespace harjoitus15
{
    partial class SekkariFM
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.kaynistaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.AjanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(90, 47);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(875, 191);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00.000";
            this.AikaLB.Click += new System.EventHandler(this.AikaLB_Click);
            // 
            // kaynistaBT
            // 
            this.kaynistaBT.Location = new System.Drawing.Point(169, 260);
            this.kaynistaBT.Name = "kaynistaBT";
            this.kaynistaBT.Size = new System.Drawing.Size(166, 61);
            this.kaynistaBT.TabIndex = 1;
            this.kaynistaBT.Text = "Käynistä";
            this.kaynistaBT.UseVisualStyleBackColor = true;
            this.kaynistaBT.Click += new System.EventHandler(this.kaynistaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(434, 260);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(166, 61);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(699, 260);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(166, 61);
            this.TyhjennaBT.TabIndex = 3;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // AjanottoTM
            // 
            this.AjanottoTM.Enabled = true;
            this.AjanottoTM.Tick += new System.EventHandler(this.AjanottoTM_Tick);
            // 
            // SekkariFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 398);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.kaynistaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SekkariFM";
            this.Text = "t15";
            this.Load += new System.EventHandler(this.SekkariFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AikaLB;
        private Button kaynistaBT;
        private Button LopetaBT;
        private Button TyhjennaBT;
        private System.Windows.Forms.Timer AjanottoTM;
    }
}