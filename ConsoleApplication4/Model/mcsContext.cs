using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Model
{
    public class mcsContext : DbContext
    {
        public mcsContext() : base("name=MCS")
        {

        }
        public virtual DbSet<TableStopReason>
            TablesStopReasons { get; set; }
    }
}
