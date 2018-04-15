using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace VkApi
{
    public struct Edge
    {
        public Friend start;
        public Friend end;
        public double weight;

        public override string ToString()
        {
            return string.Format("start - {0}, end - {1}, weight  - {2}",
                start.FirstName, end.FirstName, weight);
        }
    }

    public class NormalGraph
    {
        public static Collection<Color> webColors = new Collection<Color>
        {
            Color.FromArgb(127, 255, 12),
            Color.FromArgb(106, 90, 205),
            Color.FromArgb(199, 2, 133),
            Color.FromArgb(255, 69, 0),
            Color.FromArgb(255, 215, 0),
            Color.FromArgb(0, 191, 255),
            Color.FromArgb(255, 20, 147),
            Color.FromArgb(128, 0, 128),
            Color.FromArgb(75, 0, 130),
            Color.FromArgb(123, 104, 238),
            Color.FromArgb(173, 255, 0),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(178, 34, 34),
            Color.FromArgb(0, 250, 154),
            Color.FromArgb(32, 178, 170),
            Color.FromArgb(138, 43, 226),
            Color.FromArgb(0, 206, 209),
            Color.FromArgb(255, 255, 0),
            Color.FromArgb(176, 224, 230),
        };

        public List<Friend> nodes = new List<Friend>();
        public List<Edge> edges = new List<Edge>();

        public void makeKMeansColors(int count)
        {
            Accord.Math.Random.Generator.Seed = 0;
            KMeans kmeans = new KMeans(count);

            double[][] observations = new double[DataHolder.fullGraph.nodes.Count][];
            int counter = 0;
            foreach (Friend fr in DataHolder.fullGraph.nodes)
                observations[counter++] = new double[] { fr.FriendsCount, fr.MusicCount };

            KMeansClusterCollection clusters = kmeans.Learn(observations);

            int[] labels = clusters.Decide(observations);

            List<int> lb = labels.ToList();
            lb = lb.Distinct().ToList();


            foreach (int gl in lb)
            {
                int cnt = 0;
                Color color = webColors[gl];
                foreach (int lab in labels)
                {
                    if (gl == lab)
                    {
                        nodes[cnt].clr = color;
                    }
                    cnt++;
                }
            }
        }
    }


}
