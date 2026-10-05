using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1_olujic
{
    public class Episode
    {
        private int viewerCount;
        private double scoreSum;
        private double highestScore;


        public double GetViewerCount()
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


        public Episode()
        {
            this.viewerCount = 0;
            this.scoreSum = 0;
            this.highestScore = 0;
        }
        public Episode(int viewercount, double sum, double maxscore)
        {
            this.viewerCount = viewercount;
            this.scoreSum = sum;
            this.highestScore = maxscore;
        }
    }
}