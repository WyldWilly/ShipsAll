using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship.Data.Entities
{
    public class ShipIndex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Registry { get; set; }
        public string Class { get; set; }
        public int Type { get; set; }
        public int ClassShip { get; set; }
        public int Status { set; get; }
    }

    public class ShipTypes
    {
        public int Id { get; set; }
        public string ShipTypeName { get; set; }
        public int ShipTypeCode { get; set; }
        public string Abbrev { get; set; }
    }

    public class Initable
    {
        public int Id { get; set; }
        public string CodeSetName { get; set; }
        public string CodeSetValue { get; set; }
        public int CodeSetId { get; set; }
        public int Status { get; set; }

    }
}
