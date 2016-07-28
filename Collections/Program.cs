using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> NameAge = new Dictionary<string, int>
            {
                {"Patrick", 16 },
                {"Charlie", 20 },
                {"Samantha", 17 },
                {"Michelle", 48 }

            };
        }
        enum names { Patrick, Charlie, Samantha }
        string[] arry = { "array", "Thing" };

        List<string> FullName =
            new List<string>
            {
                "Patrick Haimbaugh",
                "Joe Keefe",
                "Patricia Jentz",
                "Charlie Haimbaugh"
            };

    }
}
