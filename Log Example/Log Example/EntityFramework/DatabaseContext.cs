using LogExample;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Log> log { get; set; }

    }
}
