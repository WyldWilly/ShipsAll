using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Ship.Data.Entities;

namespace Ship.Data.Mapper
{
    public class ShipIndex : EntityTypeConfiguration<shipindex>
    {
        public ShipIndex()
        {
            ToTable("shipindex");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar").HasMaxLength(45);
            Property(c => c.Registry).IsRequired().HasColumnName("Registry").HasColumnType("varchar").HasMaxLength(15);
            Property(c => c.Class).IsRequired().HasColumnName("Class").HasColumnType("varchar").HasMaxLength(45);
            Property(c => c.Type).IsRequired().HasColumnName("Type").HasColumnType("int");
            Property(c => c.ClassShip).IsRequired().HasColumnName("ClassShip").HasColumnType("boolean");
            Property(c => c.Status).IsRequired().HasColumnName("Status").HasColumnType("boolean");
        }
    }
}
