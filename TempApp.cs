using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemperatures
{
    internal class TempApp
    {
        private double[] temperatures;
        private DateTime[] dateTimes;

        public void Run()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Zadej počet položek");
            var count = ConvToInt(Console.ReadLine());
            temperatures = new double[count];
            dateTimes = new DateTime[count];

            //          DD-MM-YYYY: teplota
            //          07-07-2023: 

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zadejte DD-MM-YYYY: teplota");
                var input = Console.ReadLine();
                var result = input.Split(':');

                temperatures[i] = ConvToDouble(result[1]);

                var dateArr = result[0].Split('-');
                var year = ConvToInt(dateArr[2]);
                var month = ConvToInt(dateArr[1]);
                var day = ConvToInt(dateArr[0]);
                dateTimes[i] = new DateTime(year, month, day);
            }

            for(int i = 0; i < count;i++)
            {
                Console.WriteLine($"Dne {dateTimes[i].ToString("dd-MM-YYYY")} byla teplota {temperatures[i]} °C.");
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
