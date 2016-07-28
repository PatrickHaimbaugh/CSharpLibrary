using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main()
        {
            var DaysOfTheWeek = new List<string>
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            foreach (var Days in DaysOfTheWeek)
            {
                Console.WriteLine($"{Days}");
            }
        }



    }
}
