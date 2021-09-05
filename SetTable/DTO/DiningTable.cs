using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetTable
{
    public class DiningTable
    {
        public string Table { get; set; }
        public int Status { get; set; }
        public int Floor { get; set; }
        public int ID { get; set; }


        public DiningTable()
        {

        }

        public DiningTable(int ID, string Table, int Status, int Floor)
        {
            this.ID = ID;
            this.Table = Table;
            this.Status = Status;
            this.Floor = Floor;
        }
    }
}
