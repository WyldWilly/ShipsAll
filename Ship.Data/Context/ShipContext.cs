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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShipIndexMapper());
            base.OnModelCreating(modelBuilder);

        }

    }
}
