using Proyecto_final.DBclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_final
{
    public partial class Comentario : PantallaInicial
    {
        public Comentario()
        {
            InitializeComponent();
        }

        private void Comentario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalFP db = new PrincipalFP();
            DBclass.Cometario Co = new DBclass.Cometario();
            Co.Comentario = textBox4.Text;

            db.Comentario.Add(Co);
            db.SaveChanges();


            MessageBox.Show("Registro exito.");
            textBox1.Clear();
            textBox4.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
