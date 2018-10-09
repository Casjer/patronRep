using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatroRepos.Entidad
{
     public class Cuentas
    {
        [Key]
        public int Cuenta { get; set; }
        public string Descripcion { get; set; }

        public Cuentas()
        {
            Cuenta = 0;
            Descripcion = string.Empty;
        }

    }

   
}
