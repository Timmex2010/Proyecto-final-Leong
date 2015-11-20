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
    public partial class ModificarLibro : PantallaInicial
    {
        public ModificarLibro()
        {
            InitializeComponent();
        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrincipalFP db = new PrincipalFP();
            int idLibro = int.Parse(textBox2.Text);
            var agent = db.Libro
                      .SingleOrDefault(x => x.idLibro == idLibro);
            // where x.id == id
            //select x;

            if (agent != null)
            {
                agent.Fecha = textBox3.Text;
                agent.Titulo = textBox4.Text;

                db.SaveChanges();
            }
            MessageBox.Show("Modificar exito.");
        }
    }
}
