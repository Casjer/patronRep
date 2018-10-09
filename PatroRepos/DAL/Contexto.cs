using PatroRepos.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PatroRepos.DAL
{
     public class Contexto : DbContext
    {
        public DbSet<Cuentas> Cuentas { get; set; }
        public Contexto() : base("constr")
        { }
    }
}
