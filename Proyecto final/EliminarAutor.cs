﻿using Proyecto_final.DBclass;
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
    public partial class EliminarAutor : PantallaInicial
    {
        public EliminarAutor()
        {
            InitializeComponent();
        }

        private void EliminarAutor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                PrincipalFP db = new PrincipalFP();
                int idAutor = int.Parse(textBox1.Text);
                var emp = db.Autor
                          .SingleOrDefault(x => x.idAutor == idAutor);
                // where x.id == id
                //select x;

                if (emp != null)
                {
                    db.Autor.Remove(emp);
                    MessageBox.Show("Eliminar exito.");
                    db.SaveChanges();
                }
            }
            else { MessageBox.Show("Solo numeros #id"); }
        }
    }
}
