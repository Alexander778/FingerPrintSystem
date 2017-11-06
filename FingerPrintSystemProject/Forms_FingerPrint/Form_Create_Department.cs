using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FingerPrint
{
    public partial class Form_Create_Department : Form
    {
        public Form_Create_Department()
        {
            InitializeComponent();
        }

        private void tbo_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Form_Create_Department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet2.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet2.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet1.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            nameTextBox.Enabled = true;
            companyIDComboBox.Enabled = true;
            regimeTextBox.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            checkBox1.Enabled = true;
            button1.Enabled = false;

            


            tbo_DepartmentBindingSource.AddNew();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbo_DepartmentBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tbo_DepartmentBindingSource.EndEdit();
                tbo_DepartmentTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
                nameTextBox.BackColor = Color.White;
                regimeTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;
                button2.Enabled = true;
                button1.Enabled = true;

                nameTextBox.Enabled = false;
                companyIDComboBox.Enabled = false;
                regimeTextBox.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                checkBox1.Enabled = false;
                

            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("You did not write all information about department",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TextBox[] txtboxes = new TextBox[2];
                txtboxes[0] = nameTextBox;
                txtboxes[1] = regimeTextBox;
                
                for (int i = 0; i <= txtboxes.Length-1; i++)
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
                if (companyIDComboBox.Text != "")
                {
                    pictureBox1.Visible = false;
                }
                else
                {
                    pictureBox1.Visible = true;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Your company(ies) and departments were created!Now,please, add information about administrator profile and change password!";
            string caption = "FingerPrintSystem::Change information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            ChangePasswordAdmin ch1 = new ChangePasswordAdmin();
            ch1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbo_DepartmentDataGridView.Visible = true;
            }
            else
            {
                tbo_DepartmentDataGridView.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Create_Company f1 = new Form_Create_Company();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
