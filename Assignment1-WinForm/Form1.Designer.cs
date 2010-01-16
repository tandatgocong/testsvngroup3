namespace Assignment1
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.lbQualification = new System.Windows.Forms.Label();
            this.listQualification = new System.Windows.Forms.ListBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.maskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbDateofJoining = new System.Windows.Forms.Label();
            this.maskJoining = new System.Windows.Forms.MaskedTextBox();
            this.linkVN = new System.Windows.Forms.LinkLabel();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(30, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(90, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Employee Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(30, 81);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(72, 13);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date of Birth :";
            // 
            // maskDate
            // 
            this.maskDate.Location = new System.Drawing.Point(138, 81);
            this.maskDate.Mask = "00/00/0000";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(72, 20);
            this.maskDate.TabIndex = 3;
            this.maskDate.ValidatingType = typeof(System.DateTime);
            this.maskDate.Leave += new System.EventHandler(this.maskDate_Leave);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(30, 134);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 13);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 131);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(30, 225);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(30, 13);
            this.lbCity.TabIndex = 6;
            this.lbCity.Text = "City :";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.Location = new System.Drawing.Point(138, 225);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(189, 56);
            this.listCity.TabIndex = 7;
            this.listCity.Leave += new System.EventHandler(this.listCity_Leave);
            // 
            // lbQualification
            // 
            this.lbQualification.AutoSize = true;
            this.lbQualification.Location = new System.Drawing.Point(30, 310);
            this.lbQualification.Name = "lbQualification";
            this.lbQualification.Size = new System.Drawing.Size(71, 13);
            this.lbQualification.TabIndex = 8;
            this.lbQualification.Text = "Qualification :";
            // 
            // listQualification
            // 
            this.listQualification.FormattingEnabled = true;
            this.listQualification.Items.AddRange(new object[] {
            "University",
            "Master",
            "Ph D"});
            this.listQualification.Location = new System.Drawing.Point(138, 310);
            this.listQualification.Name = "listQualification";
            this.listQualification.Size = new System.Drawing.Size(189, 56);
            this.listQualification.TabIndex = 9;
            this.listQualification.SelectedIndexChanged += new System.EventHandler(this.listQualification_SelectedIndexChanged);
            this.listQualification.Leave += new System.EventHandler(this.listQualification_Leave);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(30, 395);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(44, 13);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone :";
            // 
            // maskPhone
            // 
            this.maskPhone.Location = new System.Drawing.Point(138, 388);
            this.maskPhone.Mask = "000-0000000";
            this.maskPhone.Name = "maskPhone";
            this.maskPhone.Size = new System.Drawing.Size(88, 20);
            this.maskPhone.TabIndex = 11;
            this.maskPhone.Leave += new System.EventHandler(this.maskPhone_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(30, 453);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 446);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbDateofJoining
            // 
            this.lbDateofJoining.AutoSize = true;
            this.lbDateofJoining.Location = new System.Drawing.Point(30, 501);
            this.lbDateofJoining.Name = "lbDateofJoining";
            this.lbDateofJoining.Size = new System.Drawing.Size(84, 13);
            this.lbDateofJoining.TabIndex = 14;
            this.lbDateofJoining.Text = "Date of Joining :";
            // 
            // maskJoining
            // 
            this.maskJoining.Location = new System.Drawing.Point(138, 494);
            this.maskJoining.Mask = "00/00/0000";
            this.maskJoining.Name = "maskJoining";
            this.maskJoining.Size = new System.Drawing.Size(88, 20);
            this.maskJoining.TabIndex = 15;
            this.maskJoining.ValidatingType = typeof(System.DateTime);
            this.maskJoining.Leave += new System.EventHandler(this.maskJoining_Leave);
            // 
            // linkVN
            // 
            this.linkVN.AutoSize = true;
            this.linkVN.Location = new System.Drawing.Point(33, 561);
            this.linkVN.Name = "linkVN";
            this.linkVN.Size = new System.Drawing.Size(62, 13);
            this.linkVN.TabIndex = 16;
            this.linkVN.TabStop = true;
            this.linkVN.Text = "Link to mp3";
            this.linkVN.Click += new System.EventHandler(this.linkVN_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(138, 545);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 17;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(257, 544);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(30, 176);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(49, 13);
            this.lbCountry.TabIndex = 19;
            this.lbCountry.Text = "Country :";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "VietNam",
            "Y"});
            this.cbCountry.Location = new System.Drawing.Point(138, 168);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 20;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            this.cbCountry.Leave += new System.EventHandler(this.cbCountry_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 599);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.linkVN);
            this.Controls.Add(this.maskJoining);
            this.Controls.Add(this.lbDateofJoining);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.maskPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.listQualification);
            this.Controls.Add(this.lbQualification);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.maskDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.Label lbQualification;
        private System.Windows.Forms.ListBox listQualification;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.MaskedTextBox maskPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbDateofJoining;
        private System.Windows.Forms.MaskedTextBox maskJoining;
        private System.Windows.Forms.LinkLabel linkVN;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cbCountry;
    }
}

