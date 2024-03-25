namespace Hotteli
{
    partial class ManageReservationsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddReserv = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonRemoveReserv = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReservId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.dateTimePickerOUT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePickerIN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxRoomNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxReservId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveReserv);
            this.panel1.Controls.Add(this.buttonEditReserv);
            this.panel1.Controls.Add(this.buttonAddReserv);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxClientID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 511);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 87);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client ID:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(225, 99);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(210, 39);
            this.textBoxClientID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(519, 393);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonAddReserv
            // 
            this.buttonAddReserv.Location = new System.Drawing.Point(137, 422);
            this.buttonAddReserv.Name = "buttonAddReserv";
            this.buttonAddReserv.Size = new System.Drawing.Size(156, 29);
            this.buttonAddReserv.TabIndex = 12;
            this.buttonAddReserv.Text = "add reservation";
            this.buttonAddReserv.UseVisualStyleBackColor = true;
            this.buttonAddReserv.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.Location = new System.Drawing.Point(299, 422);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(80, 29);
            this.buttonEditReserv.TabIndex = 13;
            this.buttonEditReserv.Text = "Muokka";
            this.buttonEditReserv.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveReserv
            // 
            this.buttonRemoveReserv.Location = new System.Drawing.Point(385, 422);
            this.buttonRemoveReserv.Name = "buttonRemoveReserv";
            this.buttonRemoveReserv.Size = new System.Drawing.Size(97, 29);
            this.buttonRemoveReserv.TabIndex = 14;
            this.buttonRemoveReserv.Text = "Poista";
            this.buttonRemoveReserv.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(326, 457);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(156, 29);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "tyhjentä kentät";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Room type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(225, 181);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(291, 37);
            this.comboBoxRoomType.TabIndex = 18;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reserv ID:";
            // 
            // textBoxReservId
            // 
            this.textBoxReservId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservId.Location = new System.Drawing.Point(225, 140);
            this.textBoxReservId.Name = "textBoxReservId";
            this.textBoxReservId.Size = new System.Drawing.Size(210, 39);
            this.textBoxReservId.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room Number:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(225, 221);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(291, 37);
            this.comboBoxRoomNumber.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date in:";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(225, 264);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(291, 39);
            this.dateTimePickerIN.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date out:";
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(225, 309);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(291, 39);
            this.dateTimePickerOUT.TabIndex = 26;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 511);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationsForm";
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReservId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveReserv;
        private System.Windows.Forms.Button buttonEditReserv;
        private System.Windows.Forms.Button buttonAddReserv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}