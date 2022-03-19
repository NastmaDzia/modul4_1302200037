using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal4_1302200037
{
   public class SimpleDataBase<T>
    {
        private List<T>? storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            this.storedData.Add(newData);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            foreach (var data in this.storedData)
            {
                Console.WriteLine(data);
            }

            foreach (var data in this.inputDates)
            {
                Console.WriteLine();
            }
        }
    }
}
