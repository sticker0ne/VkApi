using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;

namespace VkApi
{
    public class AffinityPropagation
    {
        public static void Mark(IEnumerable<Friend> frnds, int iterationsCount, 
            double divider)
        {
            var friends = frnds.ToList();
            var s = GetSimilarityMatrix(friends, divider);
            var a = new double[friends.Count, friends.Count];
            var r = new double[friends.Count, friends.Count];
            var c = new int[friends.Count, friends.Count];

            for (var t = 0; t < iterationsCount; t++)
            {
                for (var i = 0; i < s.Columns(); i++)
                    for (var k = 0; k < s.Columns(); k++)
                        r[i, k] = s[i, k] - GetMaxJ(a, s, i, k);

                for (var i = 0; i < s.Columns(); i++)
                    for (var k = 0; k < s.Columns(); k++)
                        if (i != k)
                            a[i, k] = Math.Min(0, r[k, k] + GetSum(r, k, i));

                for (var k = 0; k < s.Columns(); k++)
                    a[k, k] = GetSum(r, k);
            }

            for (var i = 0; i < s.Columns(); i++)
                for (var k = 0; k < s.Columns(); k++)
                    if (a[i, k] + r[i, k] > 0)
                        c[i, k] = 1;

            for (var i = 0; i < s.Columns(); i++)
                if (c[i, i] == 1)
                    for (var j = 0; j < s.Columns(); j++)
                        if (c[j, i] == 1)
                            friends[j].clr = NormalGraph.webColors[i];

            Painter.paintFriendsToFile(DataHolder.fullGraph);
        }

        private static double GetMaxJ(double[,] a, double[,] s, int i, int k)
        {
            double max;
            if (k != 0)
                max = a[i, 0] + s[i, 0];
            else
                max = a[i, 1] + s[i, 1];

            for (var j = 0; j < s.Columns(); j++)
                if (j != k)
                    if (a[i, j] + s[i, j] > max)
                        max = a[i, j] + s[i, j];

            return max;
        }

        private static double GetSum(double[,] r, int k, int i = -1)
        {
            double sum = 0;

            for (var j = 0; j < r.Columns(); j++)
                if (j != i && j != k)
                    sum += Math.Max(0, r[j, k]);
            return sum;
        }
        private static double GetDistance(Friend first, Friend second)
        {
            return Math.Sqrt((second.MusicCount - first.MusicCount) *
                             (second.MusicCount - first.MusicCount) +
                             (second.FriendsCount - first.FriendsCount) *
                             (second.FriendsCount - first.FriendsCount));
        }

        private static double GetMedian(List<Friend> friends)
        {
            var count = 0;
            double res = 0;
            foreach (var friend in friends)
                foreach (var friend1 in friends)
                {
                    count++;
                    res += GetDistance(friend1, friend);
                }

            return -res / (double)count;
        }

        private static double[,] GetSimilarityMatrix(IEnumerable<Friend> frnds,
            double k)
        {
            var friends = frnds.ToList();

            var friendsCount = friends.Count();
            var s = new double[friendsCount, friendsCount];

            var median = GetMedian(friends) * k;

            for (var i = 0; i < friendsCount; i++)
                for (var j = 0; j < friendsCount; j++)
                {
                    if (i == j)
                        s[i, j] = median;
                    else
                    {
                        s[i, j] = -GetDistance(friends.ElementAt(i),
                            friends.ElementAt(j));
                    }
                }

            return s;
        }

    }
}
