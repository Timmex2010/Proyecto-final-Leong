using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaInicial vnt = new PantallaInicial();
            vnt.Show();
            Login vnt1 = new Login();
            vnt1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alta vnt = new Alta();
            vnt.Show();
        }


    }
}
