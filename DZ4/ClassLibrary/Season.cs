using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5_olujic
{
    public class Season : IEnumerable<Episode>
    {
        public int seasonNum { get; private set; }
        public List<Episode> episodes { get; private set; }
        public Episode this[int index]
        {
            get { return episodes[index]; }
            set { episodes[index] = value; }
        }
        public int Length => episodes.Count;

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
        public void Remove(string s)
        {
            int i = 0;
            foreach (Episode ep in episodes) i++;
            for (int j = 0; j < i-1; j++)
            {
                if (s == episodes[j].description.episodeTitle)
                {
                    episodes.Remove(episodes[j]);
                }
            }
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

        public IEnumerator<Episode> GetEnumerator()
        {
            return episodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Season(int seasonNum, List<Episode> eps)
        {
            this.seasonNum = seasonNum;
            this.episodes = new List<Episode>();
            foreach (Episode episode in eps)
                episodes.Add(episode);
        }
        public Season(Season season)
        {
            this.seasonNum = season.seasonNum;
            this.episodes = new List<Episode>();
            foreach (Episode episode in season.episodes)
                episodes.Add(new Episode(episode.GetViewerCount(), episode.scoreSum, episode.highestScore, episode.description));
        }
    }
}
