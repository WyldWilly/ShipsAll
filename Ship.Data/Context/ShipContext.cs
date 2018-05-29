using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ship.Data.Entities;
using Ship.Data.Mapper;

namespace Ship.Data.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ShipContext : DbContext
    {
        public ShipContext(string connString) : base(connString)
        {

        }

        //Db Sets

        public DbSet<ShipIndex> ShipI { get; set; }
        public DbSet<ShipTypes> TypeI { get; set; }
        public DbSet<Initable> IniT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShipIndexMapper());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ShipTypesMapper());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new IniTableMapper());
            base.OnModelCreating(modelBuilder);
        }

    }
}
