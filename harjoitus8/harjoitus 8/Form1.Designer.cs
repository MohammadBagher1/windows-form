namespace harjoitus_8
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
            this.RoomaTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(259, 26);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(492, 70);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "roomalaiset numerot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "anna numero 1-3999 ja minä kirjoitan sen rooman kielellä.";
            // 
            // RoomaTB
            // 
            this.RoomaTB.Location = new System.Drawing.Point(972, 140);
            this.RoomaTB.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.RoomaTB.Name = "RoomaTB";
            this.RoomaTB.Size = new System.Drawing.Size(237, 31);
            this.RoomaTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(93, 244);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(115, 24);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Location = new System.Drawing.Point(915, 235);
            this.MuutaBT.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(179, 32);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 432);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.RoomaTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Ravie", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label label1;
        private TextBox RoomaTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}