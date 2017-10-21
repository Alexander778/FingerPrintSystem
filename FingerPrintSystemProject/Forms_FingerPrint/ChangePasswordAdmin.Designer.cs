namespace Forms_FingerPrint
{
    partial class ChangePasswordAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label scheduleLabel;
            System.Windows.Forms.Label fingerPrintLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label roleIDLabel;
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tbo_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tbo_ProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_ProfileTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter();
            this.iDTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.scheduleTextBox = new System.Windows.Forms.TextBox();
            this.fingerPrintTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            scheduleLabel = new System.Windows.Forms.Label();
            fingerPrintLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Enabled = false;
            iDLabel.Location = new System.Drawing.Point(406, 490);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Enabled = false;
            nameLabel.Location = new System.Drawing.Point(359, 519);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(102, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Role of User:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_RoleBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(467, 484);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // tbo_RoleBindingSource
            // 
            this.tbo_RoleBindingSource.DataMember = "tbo_Role";
            this.tbo_RoleBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_RoleBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(467, 519);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // tbo_ProfileBindingSource
            // 
            this.tbo_ProfileBindingSource.DataMember = "tbo_Profile";
            this.tbo_ProfileBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = null;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = null;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = this.tbo_ProfileTableAdapter;
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_ProfileTableAdapter
            // 
            this.tbo_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(316, 85);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(30, 20);
            iDLabel1.TabIndex = 4;
            iDLabel1.Text = "ID:";
            // 
            // iDTextBox1
            // 
            this.iDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "ID", true));
            this.iDTextBox1.Location = new System.Drawing.Point(416, 82);
            this.iDTextBox1.Name = "iDTextBox1";
            this.iDTextBox1.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox1.TabIndex = 5;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(316, 117);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(55, 20);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(416, 114);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox1.TabIndex = 7;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(316, 149);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(78, 20);
            surnameLabel.TabIndex = 8;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(416, 146);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 26);
            this.surnameTextBox.TabIndex = 9;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(316, 181);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(91, 20);
            patronymicLabel.TabIndex = 10;
            patronymicLabel.Text = "Patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(416, 178);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 26);
            this.patronymicTextBox.TabIndex = 11;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbo_ProfileBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(34, 32);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(176, 202);
            this.photoPictureBox.TabIndex = 13;
            this.photoPictureBox.TabStop = false;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(316, 212);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(85, 20);
            birthDateLabel.TabIndex = 14;
            birthDateLabel.Text = "Birth Date:";
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(416, 209);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(100, 26);
            this.birthDateTextBox.TabIndex = 15;
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new System.Drawing.Point(316, 244);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new System.Drawing.Size(80, 20);
            scheduleLabel.TabIndex = 16;
            scheduleLabel.Text = "Schedule:";
            // 
            // scheduleTextBox
            // 
            this.scheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Schedule", true));
            this.scheduleTextBox.Location = new System.Drawing.Point(416, 241);
            this.scheduleTextBox.Name = "scheduleTextBox";
            this.scheduleTextBox.Size = new System.Drawing.Size(100, 26);
            this.scheduleTextBox.TabIndex = 17;
            // 
            // fingerPrintLabel
            // 
            fingerPrintLabel.AutoSize = true;
            fingerPrintLabel.Location = new System.Drawing.Point(20, 397);
            fingerPrintLabel.Name = "fingerPrintLabel";
            fingerPrintLabel.Size = new System.Drawing.Size(94, 20);
            fingerPrintLabel.TabIndex = 18;
            fingerPrintLabel.Text = "Finger Print:";
            // 
            // fingerPrintTextBox
            // 
            this.fingerPrintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "FingerPrint", true));
            this.fingerPrintTextBox.Location = new System.Drawing.Point(120, 394);
            this.fingerPrintTextBox.Name = "fingerPrintTextBox";
            this.fingerPrintTextBox.Size = new System.Drawing.Size(100, 26);
            this.fingerPrintTextBox.TabIndex = 19;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(316, 280);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(416, 277);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox.TabIndex = 21;
            // 
            // roleIDLabel
            // 
            roleIDLabel.AutoSize = true;
            roleIDLabel.Location = new System.Drawing.Point(316, 312);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(67, 20);
            roleIDLabel.TabIndex = 22;
            roleIDLabel.Text = "Role ID:";
            // 
            // roleIDTextBox
            // 
            this.roleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "RoleID", true));
            this.roleIDTextBox.Location = new System.Drawing.Point(416, 309);
            this.roleIDTextBox.Name = "roleIDTextBox";
            this.roleIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.roleIDTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Make photo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 30);
            this.button3.TabIndex = 26;
            this.button3.Text = "Add FingerPrint";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 33);
            this.button4.TabIndex = 27;
            this.button4.Text = "Add Admin User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(542, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 38);
            this.button5.TabIndex = 28;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(320, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 34);
            this.button6.TabIndex = 29;
            this.button6.Text = "Remove this account";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ChangePasswordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 563);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDTextBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(scheduleLabel);
            this.Controls.Add(this.scheduleTextBox);
            this.Controls.Add(fingerPrintLabel);
            this.Controls.Add(this.fingerPrintTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(roleIDLabel);
            this.Controls.Add(this.roleIDTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePasswordAdmin";
            this.Text = "ChangePasswordAdmin";
            this.Load += new System.EventHandler(this.ChangePasswordAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter tbo_ProfileTableAdapter;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource tbo_ProfileBindingSource;
        private System.Windows.Forms.TextBox iDTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.TextBox fingerPrintTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox roleIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}