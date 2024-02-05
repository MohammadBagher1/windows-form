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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "nopan heitto";
            // 
            // Nopa1PB
            // 
            this.Nopa1PB.Image = global::harjoitus_11.Properties.Resources.dice01;
            this.Nopa1PB.Location = new System.Drawing.Point(307, 188);
            this.Nopa1PB.Name = "Nopa1PB";
            this.Nopa1PB.Size = new System.Drawing.Size(111, 128);
            this.Nopa1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nopa1PB.TabIndex = 1;
            this.Nopa1PB.TabStop = false;
            // 
            // Nopa2PB
            // 
            this.Nopa2PB.Image = global::harjoitus_11.Properties.Resources.dice01;
            this.Nopa2PB.Location = new System.Drawing.Point(424, 188);
            this.Nopa2PB.Name = "Nopa2PB";
            this.Nopa2PB.Size = new System.Drawing.Size(114, 128);
            this.Nopa2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nopa2PB.TabIndex = 2;
            this.Nopa2PB.TabStop = false;
            // 
            // buttonBT
            // 
            this.buttonBT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBT.Location = new System.Drawing.Point(307, 323);
            this.buttonBT.Name = "buttonBT";
            this.buttonBT.Size = new System.Drawing.Size(231, 85);
            this.buttonBT.TabIndex = 3;
            this.buttonBT.Text = "button1";
            this.buttonBT.UseVisualStyleBackColor = false;
            this.buttonBT.Click += new System.EventHandler(this.buttonBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 632);
            this.Controls.Add(this.Nopa1PB);
            this.Controls.Add(this.buttonBT);
            this.Controls.Add(this.Nopa2PB);
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