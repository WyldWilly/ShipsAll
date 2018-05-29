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
        public bool ClassShip { get; set; }
        public bool Status { set; get; }
    }
}
