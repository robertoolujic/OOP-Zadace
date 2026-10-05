using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3_olujic
{
    public class Season
    {
        public int seasonNum { get; private set; }
        public Episode[] episodes { get; private set; }
        public Episode this[int index]
        {
            get { return episodes[index]; }
            set { episodes[index] = value; }
        }
        public int Length => episodes.Length;

        public int GetTotalViewers()
        {
            int totalViewers = 0;
            foreach (Episode episode in episodes)
            {
                totalViewers += episode.GetViewerCount();
                
            }
            return totalViewers;
        }
        public TimeSpan SeasonDuration()
        {
            TimeSpan SeasonDuration = TimeSpan.FromMinutes(0);
            foreach (Episode episode in episodes)
            {
                SeasonDuration += episode.GetEpisodeLength();
            }
            return SeasonDuration;
        }
        public DateTime GetBingeEnd()
        {
            return DateTime.Now + SeasonDuration();
        }

        public override string ToString()
        {
            string message = "Season 1:\r\n=================================================\r\n";
            foreach (Episode episode in episodes)
            {
                message += $"{episode.ToString()}\r\n";
            }
            message += "Report:\r\n=================================================\r\n";
            message += $"Total viewers: {GetTotalViewers()}\r\n";
            message += $"Total duration: {SeasonDuration()}\r\n";
            message += "=================================================\r\n";
            return message;
        }
        public Season(int seasonNum, Episode[] episodes)
        {
            this.seasonNum = seasonNum;
            this.episodes = episodes;
        }
    }
}
