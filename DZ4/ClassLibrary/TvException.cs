using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Zadaca5_olujic
{
    public class TvException : Exception
    {
        public string? Title { get; set; }
        public TvException(string Title)
            : base("No such episode found.")
        {
            this.Title = Title;
        }
    }
}
