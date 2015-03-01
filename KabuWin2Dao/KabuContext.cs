using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KabuWin2Dao
{
    public class KabuContext : DbContext
    {
        public DbSet<TKabuZandaka> TKabuZandakas { get; set; }
    }
}
