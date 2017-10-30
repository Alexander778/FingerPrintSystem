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
    public partial class Form_Create_Company : Form
    {
        public Form_Create_Company()
        {
            InitializeComponent();

        }

        private void tbo_CompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_CompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Form_Create_Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet1.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter1.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);
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
            Form_Create_Company f1 = new Form_Create_Company();

           
            nameTextBox.Enabled = true;
            button3.Enabled = true;
            label1.Visible = true;
            b_LoadLogo.Enabled = true;
            button2.Enabled = true;
            checkBox1.Enabled = true;
            button1.Enabled = true;
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
			tbo_CompanyBindingSource.EndEdit();
            tbo_CompanyTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
		}

        private void button3_Click(object sender, EventArgs e)
        {
            tbo_CompanyBindingSource.RemoveCurrent();
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
                    сompanyLogoPictureBox.Image = image;
                    сompanyLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    сompanyLogoPictureBox.Invalidate();
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
            this.Hide();
            

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
    }
}
