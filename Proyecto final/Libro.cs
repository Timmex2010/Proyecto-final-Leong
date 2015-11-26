﻿using Proyecto_final.DBclass;
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
    public partial class Libro : PantallaInicial
    {
        public Libro()
        {
            InitializeComponent();
        }

        private void Libro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalFP db = new PrincipalFP();
            DBclass.Libro li = new DBclass.Libro();
            li.Fecha = textBox3.Text;
            li.Titulo = textBox4.Text;
            db.Libro.Add(li);
            db.SaveChanges();


            MessageBox.Show("Registro exito.");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
