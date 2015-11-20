using Proyecto_final.DBclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Proyecto_final
{
    public partial class ModificarComentario : PantallaInicial
    {
        public ModificarComentario()
        {
            InitializeComponent();
        }

        private void ModificarComentario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalFP db = new PrincipalFP();
            int Comentario = int.Parse(textBox1.Text);
            var agent = db.Comentario
                      .SingleOrDefault(x => x.idcomentario == Comentario);
            // where x.id == id
            //select x;

            if (agent != null)
            {
                agent.Comentario = textBox2.Text;


                db.SaveChanges();
            }
            MessageBox.Show("Modificar exito.");
        }
    }
}
