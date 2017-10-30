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
    public partial class FirstEnter : Form
    {
      
        public FirstEnter()
        {
            InitializeComponent();
        }

        private void FirstEnter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void tbo_ProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_ProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";

            con.Open();

            
            string txtName = textBox2.Text;
            string txtPassword = textBox3.Text;

            string query = "SELECT * FROM tbo_Profile WHERE Name = @name AND Password=@passwd";
            SqlCommand cmd = new SqlCommand(query, con);

            
            
            cmd.Parameters.Add(new SqlParameter("@name", txtName));
            cmd.Parameters.Add(new SqlParameter("@passwd", txtPassword));

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)

            {
                MessageBox.Show("Login Succesfull");
                Admin_Panel ad1 = new Admin_Panel();
                ad1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Login.Please Try Again!");
            }

           

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar < 32 || e.KeyChar >= 58) && (!Char.IsLetter(number)) && number != 8) //цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
