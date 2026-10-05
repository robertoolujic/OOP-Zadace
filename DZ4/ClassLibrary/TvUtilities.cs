using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5_olujic
{
    public static class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return (random.NextDouble() * 10);
        }
        public static void Swap(ref Episode left, ref Episode right)
        {
            Episode temp = left;
            left = right;
            right = temp;
        }

        public static Episode Parse(string input)
        {
            if (input == null) return new Episode();
            string[] arguments = input.Split(',');
            string episodeTitle = new string(input.Split(',')[5]);

            return new Episode(int.Parse(arguments[0]),double.Parse(arguments[1]),double.Parse(arguments[2]),
                new Description(int.Parse(arguments[3]), TimeSpan.Parse(arguments[4]), arguments[5])
                    );
        }
        public static void Sort(Episode[] episodes)
        {
            for (int i=0; i<episodes.Length-1; i++)
            {
                for (int j = 0; j < episodes.Length-i-1; j++)
                {
                    if (episodes[j] < episodes[j + 1]) Swap(ref episodes[j], ref episodes[j + 1]);
                }
            }
        }
        public static List<Episode> LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInputs = File.ReadAllLines(fileName);
            List<Episode> episodes = new List<Episode>();
            for (int i = 0; i < episodesInputs.Length; i++)
            {
                episodes.Add(TvUtilities.Parse(episodesInputs[i]));
            }
            return episodes;
        }
    }
}