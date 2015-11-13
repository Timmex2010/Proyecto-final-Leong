using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Proyecto_final.DBclass
{
    public class PrincipalFP: DbContext
    {

            public DbSet<Altas> Altas{ get; set; }
        

    }



}
