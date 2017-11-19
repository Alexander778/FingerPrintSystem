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
    public partial class Form_Create_Company : Form
    {
        public Form_Create_Company()
        {
            InitializeComponent();
            tbo_CompanyDataGridView.DataError += new DataGridViewDataErrorEventHandler(tbo_CompanyDataGridView_DataError);
        }

        private void tbo_CompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_CompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Form_Create_Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet1.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

       



        private void button1_Click(object sender, EventArgs e) //Createbutton_Company_Form
        {
           // Form_Create_Company f1 = new Form_Create_Company();

           
            nameTextBox.Enabled = true;
            button3.Enabled = true;
            label1.Visible = true;
            b_LoadLogo.Enabled = true;
            button2.Enabled = true;
            checkBox1.Enabled = true;
            companyLogoPictureBox.Enabled = true;

            tbo_CompanyBindingSource.AddNew();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                tbo_CompanyBindingSource.EndEdit();
                

                nameTextBox.BackColor = Color.White;
                pictureBox1.Visible = false;

                nameTextBox.Enabled = false;
                button3.Enabled = false;
                label1.Visible = false;
                b_LoadLogo.Enabled = false;
                button2.Enabled = false;
                checkBox1.Enabled = false;
                companyLogoPictureBox.Enabled = false;
                button1.Enabled = true;

                tbo_CompanyTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);

            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("You did not write all information about company",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (nameTextBox.Text == "")
                {
                    nameTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    nameTextBox.BackColor = Color.White;
                }

            }


            //catch (System.Data.SqlClient.SqlException)
            //{
            //    MessageBox.Show("Please add company's logo",
            //         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    pictureBox1.Visible = true;
            //    if (nameTextBox.Text == "")
            //    {
            //        nameTextBox.BackColor = Color.LightPink;
            //    }
            //    else
            //    {
            //        nameTextBox.BackColor = Color.White;
            //    }

            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCompany f = new DeleteCompany();
            f.ShowDialog();
        }

        private void b_LoadLogo_Click(object sender, EventArgs e)
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
                    companyLogoPictureBox.Image = image;
                    companyLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    companyLogoPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbo_CompanyDataGridView.Visible = true;
            }
            else
            {
                tbo_CompanyDataGridView.Visible = false;
            }
        }

        private void Form_Create_Company_VisibleChanged(object sender, EventArgs e)
        {

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbo_CompanyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
                nameTextBox.Enabled = true;
                button3.Enabled = true;
                label1.Visible = true;
                b_LoadLogo.Enabled = true;
                button2.Enabled = true;
                checkBox1.Enabled = true;
                companyLogoPictureBox.Enabled = true;
            
            
            
            
        }
        
        public void tbo_CompanyDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("You did not write all information about Company!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            anError.ThrowException = false;
        }
    }
}
