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
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Autor vnt = new Autor();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Libro vnt = new Libro();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void categoriaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Categoria vnt = new Categoria();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario vnt = new ModificarUsuario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarAutor vnt = new ModificarAutor();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarLibro vnt = new ModificarLibro();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCatalogo vnt = new ModificarCatalogo();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void comentarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarComentario vnt = new ModificarComentario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarUsuario vnt = new EliminarUsuario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAutor vnt = new EliminarAutor();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }





        private void libroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarLibro vnt = new EliminarLibro();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarCategoria vnt = new EliminarCategoria();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaUsuario vnt = new ConsultaUsuario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void comentarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Comentario vnt = new Comentario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show(); 
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario vnt = new EliminarUsuario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void porFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAutor vnt = new ConsultaAutor();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void porOcupacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLibro vnt = new ConsultaLibro();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaCategoria vnt = new ConsultaCategoria();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void comentarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaComentario vnt = new ConsultaComentario();
            vnt.WindowState = FormWindowState.Maximized;
            vnt.Show();
        }

        private void usuarioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Alta vnt = new Alta();
            vnt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
