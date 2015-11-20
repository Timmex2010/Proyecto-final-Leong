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
    public partial class ConsultaUsuario : PantallaInicial
    {
        Registro modificarCliente = new Registro();
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalFP db = new PrincipalFP();
            int id = int.Parse(textBox1.Text);
            var registros = from s in db.Registro
                            where s.id == id
                            select new
                            {
                                s.id,
                                s.Password,
                                s.Nombre,
                                s.Edad,
                                s.Telefono,
                                s.Direccion
                            };
            dataGridView1.DataSource = registros.ToList();




        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}

            