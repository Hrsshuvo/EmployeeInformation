using EInfo.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einfo.Persiatance.Database
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<Deparement> Deparements { get; set; }
    }
}
