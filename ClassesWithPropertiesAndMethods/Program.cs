using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesWithPropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int Age { get; set; }

        public string GetAge()
        {
            return $"You are {Age} years old.";
        }
    }
}
