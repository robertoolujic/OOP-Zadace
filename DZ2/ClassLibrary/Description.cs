using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2_olujic
{
    public class Description
    {
        int episodeCount;
        TimeSpan episodeLength;
        string episodeTitle = "";


        public override string ToString()
        {
            return (episodeCount.ToString() + "," + episodeLength.ToString() + "," + episodeTitle);
        }
        public Description(int episodeCount, TimeSpan episodeLength, string episodeTitle)
        {
            this.episodeCount = episodeCount;
            this.episodeLength = episodeLength;
            this.episodeTitle += episodeTitle;
        }
    }
}
