using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Forms_FingerPrint
{
    public partial class ChangePasswordAdmin : Form
    {
        public ChangePasswordAdmin()
        {
            InitializeComponent();
       
        }

        private void tbo_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void ChangePasswordAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser". При необходимости она может быть перемещена или удалена.
            this.tbo_LinkDepartmentUserTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            this.roleIDComboBox.DisplayMember = "ID";
            this.roleIDComboBox.ValueMember = "ID"; //Field in the datatable which you want to be the value of the combobox
            this.roleIDComboBox.DataSource = _FINGERPRINTDB_MDFDataSet.Tables["tbo_Role"];




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //this.сompanyLogoPictureBox.Size = image.Size;
                    photoPictureBox.Image = image;
                    photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    photoPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open this file",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //make photo
        {
            MakePhotoForm f = new MakePhotoForm();
            f.Show();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                tbo_ProfileBindingSource.EndEdit();
                tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
                
                string message = "You created New Admin User. You enter to system by this account";
                string caption = "FingerPrintSystem";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);


                button4.Enabled = true;
                nameTextBox1.BackColor = Color.White;
                surnameTextBox.BackColor = Color.White;
                patronymicTextBox.BackColor = Color.White;
                fingerPrintTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.White;
                scheduleTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                button7.Enabled = true;

            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("You did not write all information about you",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //!

                //scheduleTextBox.TextFormat = MaskFormat.ExcludePromptAndLiterals;
                //if (scheduleMaskedTextBox.Text == "")
                //{
                // scheduleMaskedTextBox.BackColor = Color.LightPink;
                //}

                TextBox[] txtboxes = new TextBox[6];
                txtboxes[0] = nameTextBox1;
                txtboxes[1] = surnameTextBox;
                txtboxes[2] = patronymicTextBox;
                txtboxes[3] = fingerPrintTextBox;
                txtboxes[4] = passwordTextBox;
                txtboxes[5] = scheduleTextBox;
                

                for (int i = 0; i < txtboxes.Length; i++)
                {
                    if (txtboxes[i].Text == "")
                    {
                        txtboxes[i].BackColor = Color.LightPink;
                    }
                    else
                    {
                        txtboxes[i].BackColor = Color.White;
                    }
                }
                

                if (birthDateDateTimePicker.Value == DateTime.Today)
                {
                    pictureBox3.Visible = true;
                }
                

                if (roleIDComboBox.Text=="")
                {
                    pictureBox1.Visible = true;
                }
                

               


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            photoPictureBox.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            photoPictureBox.Enabled = true;
            fingerPrintTextBox.Enabled = true;
            button3.Enabled = true;
            nameTextBox1.Enabled = true;
            surnameTextBox.Enabled = true;
            patronymicTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            checkBox2.Enabled = true;
            roleIDComboBox.Enabled = true;
           // scheduleTextBox.Enabled = true;
            birthDateDateTimePicker.Enabled = true;
            dateCreationDateTimePicker.Enabled = true;
            button4.Enabled = false;
            button8.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            dateCreationDateTimePicker.Value = DateTime.Today;
            birthDateDateTimePicker.Value = DateTime.Today;











            tbo_ProfileBindingSource.AddNew();
            
           
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string message = "Are you sure you remove information about this account?";
            string caption = "FingerPrintSystem::Removing Account";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption,buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbo_ProfileBindingSource.RemoveCurrent();
                tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
                string message1 = "This account was deleted. If you want to create new account you should click on Add Admin User";
                string caption1 = "FingerPrintSystem";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(message1, caption1, buttons1);

                birthDateDateTimePicker.Value = DateTime.Today;
                photoPictureBox.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                photoPictureBox.Enabled = false;
                fingerPrintTextBox.Enabled = false;
                button3.Enabled = false;
                nameTextBox1.Enabled = false;
                surnameTextBox.Enabled = false;
                patronymicTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = false;
                checkBox2.Enabled = false;
                button7.Enabled = false;
                roleIDComboBox.Enabled = false;
                scheduleTextBox.Enabled = false;
                birthDateDateTimePicker.Enabled = false;
                dateCreationDateTimePicker.Enabled = false;
                tbo_ProfileDataGridView.Visible = false;
                button4.Enabled = true;
                dateCreationDateTimePicker.Value = DateTime.Today;
                birthDateDateTimePicker.Value = DateTime.Today;
                button4.Enabled = true;
                nameTextBox1.BackColor = Color.White;
                surnameTextBox.BackColor = Color.White;
                patronymicTextBox.BackColor = Color.White;
                fingerPrintTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.White;
                scheduleTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
               
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Enter_Form f1 = new Enter_Form();
            f1.Enabled = false;
            f1.Hide();
            this.Hide();
            FirstEnter fe1 = new FirstEnter();
            fe1.Show();


        }

        private void button3_Click(object sender, EventArgs e) //add fingerprint
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbo_LinkDepartmentUserBindingSource.RemoveCurrent();

        }

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tbo_ProfileDataGridView.Visible = checkBox2.Checked;

        }

        private void fingerPrintLabel_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form_Create_Department f1 = new Form_Create_Department();
            f1.Show();
            this.Hide();
        }

        private void nameTextBox1_KeyPress(object sender, EventArgs e)
        { }
            

        

        private void birthDateTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void birthDateMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
            

        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void scheduleMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <32 || e.KeyChar >= 58) && (!Char.IsLetter(number)) && number != 8) //цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar='\0';
            if (checkBox1.Checked == false)
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void button8_Click_2(object sender, EventArgs e)
        {

            try
            {
                string a = comboBox1.SelectedItem.ToString();
                string b = comboBox2.SelectedItem.ToString();

                if (a == b)
                {
                    MessageBox.Show("You can not choose 2 same days!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (scheduleTextBox != null)
                {
                    scheduleTextBox.Clear();
                    scheduleTextBox.AppendText(a + "-");
                    scheduleTextBox.AppendText(b);

                }
                else
                {
                    scheduleTextBox.AppendText(a + "-");
                    scheduleTextBox.AppendText(b);
                }
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("You did not choose any days!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
