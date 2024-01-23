namespace harjoitus_11
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
            this.Nopa1PB = new System.Windows.Forms.PictureBox();
            this.Nopa2PB = new System.Windows.Forms.PictureBox();
            this.buttonBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nopa1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nopa2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "nopan heitto";
            // 
            // Nopa1PB
            // 
            this.Nopa1PB.Location = new System.Drawing.Point(26, 124);
            this.Nopa1PB.Name = "Nopa1PB";
            this.Nopa1PB.Size = new System.Drawing.Size(150, 128);
            this.Nopa1PB.TabIndex = 1;
            this.Nopa1PB.TabStop = false;
            // 
            // Nopa2PB
            // 
            this.Nopa2PB.Location = new System.Drawing.Point(182, 124);
            this.Nopa2PB.Name = "Nopa2PB";
            this.Nopa2PB.Size = new System.Drawing.Size(150, 128);
            this.Nopa2PB.TabIndex = 2;
            this.Nopa2PB.TabStop = false;
            // 
            // buttonBT
            // 
            this.buttonBT.Location = new System.Drawing.Point(26, 258);
            this.buttonBT.Name = "buttonBT";
            this.buttonBT.Size = new System.Drawing.Size(112, 34);
            this.buttonBT.TabIndex = 3;
            this.buttonBT.Text = "button1";
            this.buttonBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 353);
            this.Controls.Add(this.buttonBT);
            this.Controls.Add(this.Nopa2PB);
            this.Controls.Add(this.Nopa1PB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Nopa1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nopa2PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox Nopa1PB;
        private PictureBox Nopa2PB;
        private Button buttonBT;
    }
}