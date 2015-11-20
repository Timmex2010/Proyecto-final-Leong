﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Proyecto_final.DBclass
{
    public class PrincipalFP : DbContext
    {

        //public DbSet<Altas> Altas { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cometario> Comentario { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Registro> Registro { get; set; }


    }



}
