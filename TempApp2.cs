using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemperatures
{
    internal class TempApp2
    {
        private Temperature[] temperatures;
        public void Run()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Zadej počet položek");
            var count = ConvToInt(Console.ReadLine());
            temperatures = new Temperature[count];

            //          DD-MM-YYYY: teplota
            //          07-07-2023: 

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zadejte DD-MM-YYYY: teplota");
                var input = Console.ReadLine();
                var result = input.Split(':');
                var value = ConvToDouble(result[1]);

                var dateArr = result[0].Split('-');
                var year = ConvToInt(dateArr[2]);
                var month = ConvToInt(dateArr[1]);
                var day = ConvToInt(dateArr[0]);
                var date = new DateTime(year, month, day);
                temperatures[i] = new Temperature(value, date);
            }

            for (int i = 0; i < count;i++)
            {
                temperatures[i].Print();
            }
        }

        public double ConvToDouble(string x)
        {
            if (double.TryParse(x, out double dec))
            {
                return dec;
            }

            return double.NaN;
        }

        public int ConvToInt(string x)
        {
            if (int.TryParse(x, out int dec))
            {
                return dec;
            }

            return int.MinValue;
        }
    }
}
