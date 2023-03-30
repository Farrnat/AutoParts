using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AutoParts
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Interior> Interiors { get; set; }

        public DbSet<Gear> Gears { get; set; }

        public DbSet<Plastic> Plastics { get; set; }

        public DbSet<Consumable> Consumables { get; set;}

        public DbSet<Wheel> Wheels { get; set; }



        public AppContext() : base("DefaultConnection") { }
    }
}
