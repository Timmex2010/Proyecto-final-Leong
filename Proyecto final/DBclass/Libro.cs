using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.DBclass
{
    public class Libro
    {
        [Key]
        public int idLibro { get; set; }
        public string Titulo { get; set; }

        public string Fecha { get; set; }
        public virtual ICollection<Registro> id { get; set; }
        public virtual ICollection<Autor> idAutor { get; set; }
        public virtual ICollection<Cometario> idcomentario { get; set; }
        public virtual ICollection<Categoria> idCategoria { get; set; }
    }
}
