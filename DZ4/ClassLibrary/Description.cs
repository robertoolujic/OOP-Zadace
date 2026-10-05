using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5_olujic
{
    public class Description
    {
        public int episodeCount { get; private set; }
        public TimeSpan episodeLength { get; private set; }
        public string? episodeTitle { get; private set; }


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
