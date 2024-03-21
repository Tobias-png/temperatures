using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTemperatures
{
    internal class Temperature
    {
        private double _value;
        private DateTime _date;

        public Temperature(double value, DateTime date)
        { _value = value; _date = date; }

        public void Print()
        {
            Console.WriteLine($"Dne {_date.ToString("dd-MM-yyyy")} byla teplota {_value} °C.");
        }
    }
}
