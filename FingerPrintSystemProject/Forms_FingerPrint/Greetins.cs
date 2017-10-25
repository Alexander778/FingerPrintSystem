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
    public partial class Greetins : Form
    {
        public Greetins()
        {
            InitializeComponent();
        }

        private void Greetins_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePasswordAdmin f1 = new ChangePasswordAdmin();
            f1.Show();
            this.Hide();
        }
    }
}
