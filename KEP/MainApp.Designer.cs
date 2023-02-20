namespace KEP
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewRequestsPerCitizen = new System.Windows.Forms.Button();
            this.buttonViewRequestsInTotal = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxIDnumber = new System.Windows.Forms.TextBox();
            this.labelIDnumber = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSubmitInsert = new System.Windows.Forms.Button();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmitUpdate = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonViewRequestsPerCitizen);
            this.panel1.Controls.Add(this.buttonViewRequestsInTotal);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 602);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KEP.Properties.Resources.keplogo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(43, 400);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 43);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search request by type and Date of Birth\r\n\r\n\r\n";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(43, 323);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 43);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Modify a registration";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(43, 250);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 43);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Deleting a registration";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonViewRequestsPerCitizen
            // 
            this.buttonViewRequestsPerCitizen.BackColor = System.Drawing.Color.Black;
            this.buttonViewRequestsPerCitizen.ForeColor = System.Drawing.Color.White;
            this.buttonViewRequestsPerCitizen.Location = new System.Drawing.Point(43, 181);
            this.buttonViewRequestsPerCitizen.Name = "buttonViewRequestsPerCitizen";
            this.buttonViewRequestsPerCitizen.Size = new System.Drawing.Size(153, 43);
            this.buttonViewRequestsPerCitizen.TabIndex = 0;
            this.buttonViewRequestsPerCitizen.Text = "View all requests (per citizen)";
            this.buttonViewRequestsPerCitizen.UseVisualStyleBackColor = false;
            this.buttonViewRequestsPerCitizen.Click += new System.EventHandler(this.buttonViewRequestsPerCitizen_Click);
            // 
            // buttonViewRequestsInTotal
            // 
            this.buttonViewRequestsInTotal.BackColor = System.Drawing.Color.Black;
            this.buttonViewRequestsInTotal.ForeColor = System.Drawing.Color.White;
            this.buttonViewRequestsInTotal.Location = new System.Drawing.Point(43, 119);
            this.buttonViewRequestsInTotal.Name = "buttonViewRequestsInTotal";
            this.buttonViewRequestsInTotal.Size = new System.Drawing.Size(153, 43);
            this.buttonViewRequestsInTotal.TabIndex = 0;
            this.buttonViewRequestsInTotal.Text = "View all requests (in total)";
            this.buttonViewRequestsInTotal.UseVisualStyleBackColor = false;
            this.buttonViewRequestsInTotal.Click += new System.EventHandler(this.buttonViewRequestsInTotal_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Black;
            this.buttonInsert.ForeColor = System.Drawing.Color.White;
            this.buttonInsert.Location = new System.Drawing.Point(43, 53);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(153, 43);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Inserting a new request";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click from the menu in the left the desired action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(555, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME EMPLOYEE";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxName.Location = new System.Drawing.Point(459, 181);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(382, 184);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Full Name:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxEmail.ForeColor = System.Drawing.Color.Silver;
            this.textBoxEmail.Location = new System.Drawing.Point(459, 242);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(398, 245);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxPhone.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPhone.Location = new System.Drawing.Point(459, 281);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(167, 22);
            this.textBoxPhone.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(349, 284);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(97, 16);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone number:\r";
            // 
            // textBoxIDnumber
            // 
            this.textBoxIDnumber.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxIDnumber.ForeColor = System.Drawing.Color.Silver;
            this.textBoxIDnumber.Location = new System.Drawing.Point(459, 209);
            this.textBoxIDnumber.Name = "textBoxIDnumber";
            this.textBoxIDnumber.Size = new System.Drawing.Size(167, 22);
            this.textBoxIDnumber.TabIndex = 6;
            // 
            // labelIDnumber
            // 
            this.labelIDnumber.AutoSize = true;
            this.labelIDnumber.ForeColor = System.Drawing.Color.White;
            this.labelIDnumber.Location = new System.Drawing.Point(375, 212);
            this.labelIDnumber.Name = "labelIDnumber";
            this.labelIDnumber.Size = new System.Drawing.Size(71, 16);
            this.labelIDnumber.TabIndex = 7;
            this.labelIDnumber.Text = "ID number:";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.ForeColor = System.Drawing.Color.White;
            this.labelBirth.Location = new System.Drawing.Point(706, 181);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(82, 16);
            this.labelBirth.TabIndex = 7;
            this.labelBirth.Text = "Date of Birth:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxAddress.ForeColor = System.Drawing.Color.Silver;
            this.textBoxAddress.Location = new System.Drawing.Point(837, 230);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(167, 22);
            this.textBoxAddress.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(706, 230);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(101, 16);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Home Address:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(692, 281);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(115, 16);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Type Of Request :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxType.ForeColor = System.Drawing.Color.White;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Birth Certificate",
            "Family Status Certificate",
            "Certificate of Citizenship ",
            "IKA insurance certificates"});
            this.comboBoxType.Location = new System.Drawing.Point(838, 277);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(167, 24);
            this.comboBoxType.TabIndex = 8;
            // 
            // buttonSubmitInsert
            // 
            this.buttonSubmitInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSubmitInsert.Location = new System.Drawing.Point(594, 333);
            this.buttonSubmitInsert.Name = "buttonSubmitInsert";
            this.buttonSubmitInsert.Size = new System.Drawing.Size(213, 47);
            this.buttonSubmitInsert.TabIndex = 9;
            this.buttonSubmitInsert.Text = "Submit";
            this.buttonSubmitInsert.UseVisualStyleBackColor = false;
            this.buttonSubmitInsert.Click += new System.EventHandler(this.buttonSubmitInsert_Click);
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(837, 181);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(256, 22);
            this.dateTimePickerBirth.TabIndex = 10;
            this.dateTimePickerBirth.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // buttonSubmitUpdate
            // 
            this.buttonSubmitUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSubmitUpdate.Location = new System.Drawing.Point(594, 333);
            this.buttonSubmitUpdate.Name = "buttonSubmitUpdate";
            this.buttonSubmitUpdate.Size = new System.Drawing.Size(213, 47);
            this.buttonSubmitUpdate.TabIndex = 9;
            this.buttonSubmitUpdate.Text = "Update";
            this.buttonSubmitUpdate.UseVisualStyleBackColor = false;
            this.buttonSubmitUpdate.Click += new System.EventHandler(this.buttonSubmitUpdate_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.Black;
            this.buttonTicket.Location = new System.Drawing.Point(1156, 553);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(103, 36);
            this.buttonTicket.TabIndex = 11;
            this.buttonTicket.Text = "Next Citizen";
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1271, 601);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.buttonSubmitInsert);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelIDnumber);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxIDnumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSubmitUpdate);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewRequestsInTotal;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonViewRequestsPerCitizen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxIDnumber;
        private System.Windows.Forms.Label labelIDnumber;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSubmitInsert;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSubmitUpdate;
        private System.Windows.Forms.Button buttonTicket;
    }
}