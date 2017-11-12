namespace Forms_FingerPrint
{
    partial class Form_Create_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Forms_FingerPrint.Properties.Settings.FINGERPRINTDB_DB"].ToString();


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
            System.Windows.Forms.Label scheduleLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label dateCreationLabel;
            System.Windows.Forms.Label roleIDLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label fingerPrintLabel;
            System.Windows.Forms.Label accessLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label positionLabel;
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tbo_ProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_ProfileTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_LinkDepartmentUserTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_LinkDepartmentUserTableAdapter();
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.tboRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.scheduleTextBox = new System.Windows.Forms.TextBox();
            this.dateCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbo_ProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.fingerPrintTextBox = new System.Windows.Forms.TextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.tbo_LinkDepartmentUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessTextBox = new System.Windows.Forms.TextBox();
            this.departmentIDLabel1 = new System.Windows.Forms.Label();
            this.userIDLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.tboDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_DepartmentTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.tbo_LinkDepartmentUserDataGridView = new System.Windows.Forms.DataGridView();
            scheduleLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            dateCreationLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            fingerPrintLabel = new System.Windows.Forms.Label();
            accessLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_LinkDepartmentUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_LinkDepartmentUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.Location = new System.Drawing.Point(454, 86);
            scheduleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new System.Drawing.Size(55, 13);
            scheduleLabel.TabIndex = 96;
            scheduleLabel.Text = "Schedule:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(157, 146);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 88;
            birthDateLabel.Text = "Birth Date:";
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(454, 180);
            dateCreationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.Size = new System.Drawing.Size(75, 13);
            dateCreationLabel.TabIndex = 85;
            dateCreationLabel.Text = "Date Creation:";
            // 
            // roleIDLabel
            // 
            roleIDLabel.AutoSize = true;
            roleIDLabel.Location = new System.Drawing.Point(454, 142);
            roleIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(46, 13);
            roleIDLabel.TabIndex = 83;
            roleIDLabel.Text = "Role ID:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(157, 79);
            nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 64;
            nameLabel1.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(157, 100);
            surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 66;
            surnameLabel.Text = "Surname:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(157, 121);
            patronymicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(62, 13);
            patronymicLabel.TabIndex = 68;
            patronymicLabel.Text = "Patronymic:";
            // 
            // fingerPrintLabel
            // 
            fingerPrintLabel.AutoSize = true;
            fingerPrintLabel.Location = new System.Drawing.Point(153, 185);
            fingerPrintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fingerPrintLabel.Name = "fingerPrintLabel";
            fingerPrintLabel.Size = new System.Drawing.Size(63, 13);
            fingerPrintLabel.TabIndex = 71;
            fingerPrintLabel.Text = "Finger Print:";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new System.Drawing.Point(749, 231);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new System.Drawing.Size(45, 13);
            accessLabel.TabIndex = 127;
            accessLabel.Text = "Access:";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(751, 178);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(79, 13);
            departmentIDLabel.TabIndex = 131;
            departmentIDLabel.Text = "Department ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(751, 201);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 132;
            userIDLabel.Text = "User ID:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1791, 351);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 134;
            iDLabel.Text = "ID:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(747, 270);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 142;
            positionLabel.Text = "Position:";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(603, 83);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 22);
            this.button8.TabIndex = 95;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.comboBox2.Location = new System.Drawing.Point(553, 104);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(41, 21);
            this.comboBox2.TabIndex = 94;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.comboBox1.Location = new System.Drawing.Point(511, 104);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 21);
            this.comboBox1.TabIndex = 93;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox3.Location = new System.Drawing.Point(339, 146);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox1.Location = new System.Drawing.Point(597, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(553, 226);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 82;
            this.checkBox2.Text = "Show Admin Table";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 244);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 22);
            this.button7.TabIndex = 81;
            this.button7.Text = "Finish registration";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Forms_FingerPrint.Properties.Resources._517a6800;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(329, 212);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 35);
            this.button6.TabIndex = 80;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.save1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(370, 212);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 35);
            this.button5.TabIndex = 79;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.user_add_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(144, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 52);
            this.button4.TabIndex = 78;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(174, 212);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 19);
            this.button3.TabIndex = 77;
            this.button3.Text = "Add FingerPrint";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(11, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 22);
            this.button2.TabIndex = 76;
            this.button2.Text = "Make photo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 20);
            this.button1.TabIndex = 75;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbo_ProfileBindingSource
            // 
            this.tbo_ProfileBindingSource.DataMember = "tbo_Profile";
            this.tbo_ProfileBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_ProfileTableAdapter
            // 
            this.tbo_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = null;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = null;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = this.tbo_LinkDepartmentUserTableAdapter;
            this.tableAdapterManager.tbo_ProfileTableAdapter = this.tbo_ProfileTableAdapter;
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_LinkDepartmentUserTableAdapter
            // 
            this.tbo_LinkDepartmentUserTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tboRoleBindingSource
            // 
            this.tboRoleBindingSource.DataMember = "tbo_Role";
            this.tboRoleBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(223, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(111, 20);
            this.nameTextBox.TabIndex = 99;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Surname", true));
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.Location = new System.Drawing.Point(223, 93);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(111, 20);
            this.surnameTextBox.TabIndex = 104;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Patronymic", true));
            this.patronymicTextBox.Enabled = false;
            this.patronymicTextBox.Location = new System.Drawing.Point(224, 119);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(110, 20);
            this.patronymicTextBox.TabIndex = 106;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbo_ProfileBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Enabled = false;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(219, 142);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.birthDateDateTimePicker.TabIndex = 108;
            // 
            // scheduleTextBox
            // 
            this.scheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "Schedule", true));
            this.scheduleTextBox.Enabled = false;
            this.scheduleTextBox.Location = new System.Drawing.Point(511, 79);
            this.scheduleTextBox.Name = "scheduleTextBox";
            this.scheduleTextBox.Size = new System.Drawing.Size(83, 20);
            this.scheduleTextBox.TabIndex = 110;
            // 
            // dateCreationDateTimePicker
            // 
            this.dateCreationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbo_ProfileBindingSource, "DateCreation", true));
            this.dateCreationDateTimePicker.Enabled = false;
            this.dateCreationDateTimePicker.Location = new System.Drawing.Point(534, 174);
            this.dateCreationDateTimePicker.Name = "dateCreationDateTimePicker";
            this.dateCreationDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.dateCreationDateTimePicker.TabIndex = 118;
            this.dateCreationDateTimePicker.Value = new System.DateTime(2017, 11, 7, 0, 0, 0, 0);
            // 
            // tbo_ProfileDataGridView
            // 
            this.tbo_ProfileDataGridView.AutoGenerateColumns = false;
            this.tbo_ProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbo_ProfileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tbo_ProfileDataGridView.DataSource = this.tbo_ProfileBindingSource;
            this.tbo_ProfileDataGridView.Location = new System.Drawing.Point(23, 303);
            this.tbo_ProfileDataGridView.Name = "tbo_ProfileDataGridView";
            this.tbo_ProfileDataGridView.ReadOnly = true;
            this.tbo_ProfileDataGridView.Size = new System.Drawing.Size(1042, 220);
            this.tbo_ProfileDataGridView.TabIndex = 119;
            this.tbo_ProfileDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbo_ProfileDataGridView_CellClick);
            this.tbo_ProfileDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbo_ProfileDataGridView_CellLeave);
            this.tbo_ProfileDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbo_ProfileDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patronymic";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Schedule";
            this.dataGridViewTextBoxColumn6.HeaderText = "Schedule";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FingerPrint";
            this.dataGridViewTextBoxColumn7.HeaderText = "FingerPrint";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn8.HeaderText = "Password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RoleID";
            this.dataGridViewTextBoxColumn9.HeaderText = "RoleID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DateCreation";
            this.dataGridViewTextBoxColumn10.HeaderText = "DateCreation";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // photoPictureBox1
            // 
            this.photoPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbo_ProfileBindingSource, "Photo", true));
            this.photoPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.photoPictureBox1.Name = "photoPictureBox1";
            this.photoPictureBox1.Size = new System.Drawing.Size(116, 137);
            this.photoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox1.TabIndex = 120;
            this.photoPictureBox1.TabStop = false;
            // 
            // fingerPrintTextBox
            // 
            this.fingerPrintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "FingerPrint", true));
            this.fingerPrintTextBox.Enabled = false;
            this.fingerPrintTextBox.Location = new System.Drawing.Point(221, 182);
            this.fingerPrintTextBox.Name = "fingerPrintTextBox";
            this.fingerPrintTextBox.Size = new System.Drawing.Size(100, 20);
            this.fingerPrintTextBox.TabIndex = 121;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.Cursor = System.Windows.Forms.Cursors.No;
            this.roleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbo_ProfileBindingSource, "RoleID", true));
            this.roleIDComboBox.DataSource = this.tboRoleBindingSource;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.Enabled = false;
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(504, 137);
            this.roleIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(82, 21);
            this.roleIDComboBox.TabIndex = 122;
            this.roleIDComboBox.ValueMember = "ID";
            // 
            // tbo_LinkDepartmentUserBindingSource
            // 
            this.tbo_LinkDepartmentUserBindingSource.DataMember = "tbo_LinkDepartmentUser";
            this.tbo_LinkDepartmentUserBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // accessTextBox
            // 
            this.accessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_LinkDepartmentUserBindingSource, "Access", true));
            this.accessTextBox.Enabled = false;
            this.accessTextBox.Location = new System.Drawing.Point(800, 227);
            this.accessTextBox.Name = "accessTextBox";
            this.accessTextBox.Size = new System.Drawing.Size(75, 20);
            this.accessTextBox.TabIndex = 128;
            // 
            // departmentIDLabel1
            // 
            this.departmentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_LinkDepartmentUserBindingSource, "DepartmentID", true));
            this.departmentIDLabel1.Location = new System.Drawing.Point(836, 178);
            this.departmentIDLabel1.Name = "departmentIDLabel1";
            this.departmentIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.departmentIDLabel1.TabIndex = 132;
            this.departmentIDLabel1.Text = "label1";
            // 
            // userIDLabel1
            // 
            this.userIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_LinkDepartmentUserBindingSource, "UserID", true));
            this.userIDLabel1.Location = new System.Drawing.Point(803, 201);
            this.userIDLabel1.Name = "userIDLabel1";
            this.userIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.userIDLabel1.TabIndex = 133;
            this.userIDLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_ProfileBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(1818, 351);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(89, 23);
            this.iDLabel1.TabIndex = 135;
            this.iDLabel1.Text = "label1";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Enabled = false;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(754, 83);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompany.TabIndex = 136;
            this.comboBoxCompany.SelectedValueChanged += new System.EventHandler(this.comboBoxCompany_SelectedValueChanged);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Enabled = false;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(754, 125);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 137;
            this.comboBoxDepartment.SelectedValueChanged += new System.EventHandler(this.comboBoxDepartment_SelectedValueChanged);
            // 
            // tboDepartmentBindingSource
            // 
            this.tboDepartmentBindingSource.DataMember = "tbo_Department";
            this.tboDepartmentBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_DepartmentTableAdapter
            // 
            this.tbo_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox2.Location = new System.Drawing.Point(885, 83);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 138;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox4.Location = new System.Drawing.Point(885, 128);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 139;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Forms_FingerPrint.Properties.Resources.add1;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(926, 169);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 32);
            this.button9.TabIndex = 140;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(926, 205);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 28);
            this.button10.TabIndex = 141;
            this.button10.Text = "Remove";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_LinkDepartmentUserBindingSource, "Position", true));
            this.positionTextBox.Enabled = false;
            this.positionTextBox.Location = new System.Drawing.Point(800, 267);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(75, 20);
            this.positionTextBox.TabIndex = 143;
            // 
            // tbo_LinkDepartmentUserDataGridView
            // 
            this.tbo_LinkDepartmentUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbo_LinkDepartmentUserDataGridView.Location = new System.Drawing.Point(1113, 47);
            this.tbo_LinkDepartmentUserDataGridView.Name = "tbo_LinkDepartmentUserDataGridView";
            this.tbo_LinkDepartmentUserDataGridView.Size = new System.Drawing.Size(520, 496);
            this.tbo_LinkDepartmentUserDataGridView.TabIndex = 143;
            this.tbo_LinkDepartmentUserDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbo_LinkDepartmentUserDataGridView_CellClick);
            // 
            // Form_Create_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 591);
            this.Controls.Add(this.tbo_LinkDepartmentUserDataGridView);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDLabel1);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDLabel1);
            this.Controls.Add(accessLabel);
            this.Controls.Add(this.accessTextBox);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.fingerPrintTextBox);
            this.Controls.Add(this.photoPictureBox1);
            this.Controls.Add(this.tbo_ProfileDataGridView);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.scheduleTextBox);
            this.Controls.Add(this.dateCreationDateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(scheduleLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(dateCreationLabel);
            this.Controls.Add(roleIDLabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(fingerPrintLabel);
            this.Name = "Form_Create_User";
            this.Text = "Form_Create_User";
            this.Load += new System.EventHandler(this.Form_Create_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_LinkDepartmentUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_LinkDepartmentUserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_ProfileBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter tbo_ProfileTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private System.Windows.Forms.BindingSource tboRoleBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.DateTimePicker dateCreationDateTimePicker;
        private System.Windows.Forms.PictureBox photoPictureBox1;
        private System.Windows.Forms.TextBox fingerPrintTextBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_LinkDepartmentUserTableAdapter tbo_LinkDepartmentUserTableAdapter;
        private System.Windows.Forms.BindingSource tbo_LinkDepartmentUserBindingSource;
        private System.Windows.Forms.TextBox accessTextBox;
        private System.Windows.Forms.Label departmentIDLabel1;
        private System.Windows.Forms.Label userIDLabel1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.BindingSource tboDepartmentBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter tbo_DepartmentTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DataGridView tbo_LinkDepartmentUserDataGridView;
        public System.Windows.Forms.DataGridView tbo_ProfileDataGridView;
    }
}