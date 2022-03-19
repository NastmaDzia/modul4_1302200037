using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal4_1302200037
{
    public class Penjumlahan<T>
    {
        private T data;

        public Penjumlahan(T data)
        {

        }

        public static int JumlahTigaAngka(T a1, T a2, T a3)
        {
            int A1 = Convert.ToInt32(a1);
            int A2 = Convert.ToInt32(a2);
            int A3 = Convert.ToInt32(a3);

            int hasil = A1 + A2 + A3;

            return hasil;
        }
    }
}