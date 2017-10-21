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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

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
                    photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbo_ProfileBindingSource.EndEdit();
            tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
                string message1 = "This account was deleted. If you want to create new account you should click on Add Admin User";
                string caption1 = "FingerPrintSystem::Success Operation";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(message1, caption1, buttons1);
            }
            else
            {
                

            }
        }
    }
}
