using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3_olujic
{
    public class ConsolePrinter : IPrinter
    {
        public ConsolePrinter() { }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
