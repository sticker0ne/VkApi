using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
    static class Painter
    {
        const int photoSize = 200;
        static int multiplier = 2;
        static int maxX = 0;
        static int maxY = 0;

        public static void saveSize(NormalGraph graph)
        {
            maxX = graph.nodes.OrderByDescending(n => n.FriendsCount).ToList()[0]
                .FriendsCount * multiplier + photoSize * 2;

            maxY = graph.nodes.OrderByDescending(n => n.MusicCount).ToList()[0]
                .MusicCount * multiplier + photoSize * 2;
        }

        public static void paintFullGraphToFile(NormalGraph graph, int mult)
        {
            multiplier = mult;
            maxX = graph.nodes.OrderByDescending(n => n.FriendsCount).ToList()[0]
                .FriendsCount * multiplier + photoSize * 2;

            maxY = graph.nodes.OrderByDescending(n => n.MusicCount).ToList()[0]
                .MusicCount * multiplier + photoSize * 2;

            List<NormalGraph> list = new List<NormalGraph>();
            list.Add(graph);
            paintGraphsToFile(list);
        }

        public static void paintFriendsToFile(NormalGraph graph)
        {
            maxX = graph.nodes.OrderByDescending(n => n.FriendsCount).ToList()[0]
                .FriendsCount * multiplier + photoSize * 2;

            maxY = graph.nodes.OrderByDescending(n => n.MusicCount).ToList()[0]
                .MusicCount * multiplier + photoSize * 2;

            Bitmap fullImage = new Bitmap(maxX, maxY);
            Graphics g = Graphics.FromImage(fullImage);

            using (WebClient wc = new WebClient())
            {
                foreach (Friend friend in graph.nodes)
                {
                    byte[] originalData = wc.DownloadData(friend.Photo);
                    using (MemoryStream stream = new MemoryStream(originalData))
                    {
                        g.FillRectangle(new SolidBrush(friend.clr),
                            new Rectangle(friend.FriendsCount * multiplier - 25,
                            friend.MusicCount * multiplier - 25,
                            photoSize + 110, photoSize + 110));
                    }
                }

                
                foreach (Friend friend in graph.nodes)
                {
                    byte[] originalData = wc.DownloadData(friend.Photo);
                    using (MemoryStream stream = new MemoryStream(originalData))
                    {
                        g.DrawImage(Image.FromStream(stream),
                            friend.FriendsCount * multiplier,
                            friend.MusicCount * multiplier);
                    }
                }
                

            }

            fullImage.Save("test.tiff");
            Process.Start("test.tiff");
        }

        public static void paintGraphsToFile(List<NormalGraph> graphs)
        {
            if (maxX == 0 || maxY == 0)
                return;
            Bitmap fullImage = new Bitmap(maxX, maxY);
            Graphics g = Graphics.FromImage(fullImage);

            using (WebClient wc = new WebClient())
            {
                foreach (NormalGraph graph in graphs)
                {
                    foreach (Edge edge in graph.edges)
                    {
                        using (Pen pen = new Pen(Color.Aqua))
                        {
                            pen.Width = 20;
                            g.DrawLine(pen,
                                edge.start.FriendsCount * multiplier + photoSize / 2,
                                edge.start.MusicCount * multiplier + photoSize / 2,
                                 edge.end.FriendsCount * multiplier + photoSize / 2,
                                edge.end.MusicCount * multiplier + photoSize / 2);
                        }
                    }

                    foreach (Friend friend in graph.nodes)
                    {
                        byte[] originalData = wc.DownloadData(friend.Photo);
                        using (MemoryStream stream = new MemoryStream(originalData))
                        {
                            g.DrawImage(Image.FromStream(stream),
                                friend.FriendsCount * multiplier,
                                friend.MusicCount * multiplier);
                        }
                    }
                }
            }

            fullImage.Save("test.tiff");
            Process.Start("test.tiff");
        }
    }
}
