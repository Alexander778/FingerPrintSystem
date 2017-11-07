using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Forms_FingerPrint
{
    public partial class Form_Create_User : Form
    {
        public Form_Create_User()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            photoPictureBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            photoPictureBox1.Enabled = true;
            fingerPrintTextBox.Enabled = true;
            button3.Enabled = true;
            nameTextBox.Enabled = true;
            surnameTextBox.Enabled = true;
            patronymicTextBox.Enabled = true;
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

        private void tbo_ProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_ProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Form_Create_User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser". При необходимости она может быть перемещена или удалена.
            this.tbo_LinkDepartmentUserTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
            comboBox3.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox3.Items.Add(dt.Rows[i]["Name"]);
            }

            
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
                    photoPictureBox1.Image = image;
                    photoPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    photoPictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open this file",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you remove information about this account?";
            string caption = "FingerPrintSystem::Removing Account";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbo_ProfileBindingSource.RemoveCurrent();
                tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);

                birthDateDateTimePicker.Value = DateTime.Today;
                photoPictureBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                photoPictureBox1.Enabled = false;
                fingerPrintTextBox.Enabled = false;
                button3.Enabled = false;
                nameTextBox.Enabled = false;
                surnameTextBox.Enabled = false;
                patronymicTextBox.Enabled = false;
                button5.Enabled = false;
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
                nameTextBox.BackColor = Color.White;
                surnameTextBox.BackColor = Color.White;
                patronymicTextBox.BackColor = Color.White;
                fingerPrintTextBox.BackColor = Color.White;
                scheduleTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                tbo_ProfileBindingSource.EndEdit();
                tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);

                


                button4.Enabled = true;
                nameTextBox.BackColor = Color.White;
                surnameTextBox.BackColor = Color.White;
                patronymicTextBox.BackColor = Color.White;
                fingerPrintTextBox.BackColor = Color.White;
                scheduleTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                button7.Enabled = true;

            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("You did not write all information about you",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          

                TextBox[] txtboxes = new TextBox[5];
                txtboxes[0] = nameTextBox;
                txtboxes[1] = surnameTextBox;
                txtboxes[2] = patronymicTextBox;
                txtboxes[3] = fingerPrintTextBox;
                txtboxes[4] = scheduleTextBox;


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
                else
                {
                    pictureBox3.Visible = false;
                }


                if (roleIDComboBox.Text == "")
                {
                    pictureBox1.Visible = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
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
            catch (System.NullReferenceException)
            {
                MessageBox.Show("You did not choose any days!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tbo_ProfileDataGridView.Visible = checkBox2.Checked;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            
            comboBox3.Items.Clear();

            //
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Name FROM tbo_Department WHERE CompanyID=" + dt.Rows[comboBox3.SelectedIndex]["ID"], con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBox4.Items.Add(dt1.Rows[i]["Name"]);
            }

            comboBox4.SelectedIndex = 0;
            departmentIDLabel1.Text = dt.Rows[comboBox4.SelectedIndex]["ID"].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbo_LinkDepartmentUserBindingSource.AddNew();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        

        

        private void tbo_ProfileDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userIDLabel1.Text = tbo_ProfileDataGridView.CurrentCell.Value.ToString();
        }

        private void comboBox3_SelectedValueChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            comboBox3.Items.Clear();

            //
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Name FROM tbo_Department WHERE CompanyID=" + dt.Rows[comboBox3.SelectedIndex]["ID"], con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBox4.Items.Add(dt1.Rows[i]["Name"]);
            }

            comboBox4.SelectedIndex = 0;
        }
    }
}

