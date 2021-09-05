using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetTable
{
    public static class WorkingContext
    {
        public static List<DiningTable> tables = new List<DiningTable>();

		public static bool check = false;

        static WorkingContext()
        {
			tables = CreateDataTableList();
        }

		private static List<DiningTable> CreateDataTableList()
		{
			var result = new List<DiningTable>();
			Random r = new Random();

			for (int i = 1; i < 27; i++)
			{
				DiningTable table = new DiningTable();
				table.Table = $"Bàn {i}";
				table.ID = i;
				table.Status = r.Next(0, 2); // 0 - Trống, 1 - Có người 
				table.Floor = r.Next(1, 4);
				result.Add(table);
			}
			return result;
		}
	}
}
