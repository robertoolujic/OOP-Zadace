using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5_olujic
{
    public class FilePrinter : IPrinter
    {
        string filename;

        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void Print(string message)
        {
        File.WriteAllText($"{filename}", message);
        }
    }
}
