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
    public partial class ModificarUsuario : PantallaInicial
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+$"))
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
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(textBox12.Text, @"^\d+$") && Regex.IsMatch(textBox11.Text, @"^\d+$") && Regex.IsMatch(textBox10.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox9.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox8.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox7.Text, @"^\d+$"))
            //{
                PrincipalFP db = new PrincipalFP();
                int id = int.Parse(textBox12.Text);
                var agent = db.Registro
                          .SingleOrDefault(x => x.id == id);
                // where x.id == id
                //select x;

                if (agent != null)
                {
                    agent.Password = int.Parse(textBox11.Text);
                    agent.Nombre = textBox10.Text;
                    agent.Edad = int.Parse(textBox9.Text);
                    agent.Telefono = textBox8.Text;
                    agent.Direccion = textBox7.Text;
                    db.SaveChanges();
                }
            MessageBox.Show("Modificar exito.");
            //}
            //else { MessageBox.Show("Verifique ingresar los campos correctos"); }
        }
    }
}