using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3_olujic
{
    public class Episode
    {
        private int viewerCount;
        private double scoreSum;
        private double highestScore;
        private Description description;


        public int GetViewerCount()
        {
            return viewerCount;
        }
        public double GetMaxScore()
        {
            return highestScore;
        }
        public double GetAverageScore()
        {
            if (viewerCount == 0) return 0;
            return (scoreSum / viewerCount);
        }
        public void AddView(double score)
        {
            viewerCount++;
            this.scoreSum += score;
            if (score > highestScore)
                highestScore = score;
        }

        public TimeSpan GetEpisodeLength()
        {
            return description.episodeLength;
        }

        public static bool operator >(Episode left, Episode right)
        {
            if (left.scoreSum > right.scoreSum) return true;
            return false;
        }
        public static bool operator >=(Episode left, Episode right)
        {
            if (left.scoreSum >= right.scoreSum) return true;
            return false;
        }
        public static bool operator<(Episode left, Episode right)
        {
            return !(left >= right);
        }
        public static bool operator<=(Episode left, Episode right)
        {
            return !(left > right);
        }

        public override string ToString()
        {
            return (viewerCount.ToString() + "," + scoreSum.ToString() + "," + highestScore.ToString() + "," + description.ToString());
        }

        public Episode()
        {
            this.viewerCount = 0;
            this.scoreSum = 0;
            this.highestScore = 0;
            this.description = new Description(1, TimeSpan.FromMinutes(0), "Unnamed episode");
        }
        public Episode(int viewerCount, double scoreSum, double maxScore, Description description)
        {
            this.viewerCount = viewerCount;
            this.scoreSum = scoreSum;
            this.highestScore = maxScore;
            this.description = description;
        }
    }
}