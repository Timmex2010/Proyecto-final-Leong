using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.DBclass
{
    public class Cometario
    {
        [Key]

        public string Comentario { get; set; }
        public int idcomentario { get; set; }

        public virtual ICollection<Libro> idLibro { get; set; }
    }
}
