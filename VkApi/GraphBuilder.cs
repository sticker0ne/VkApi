using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
    class GraphBuilder
    {
        static List<NormalGraph> Trees = new List<NormalGraph>();
        static List<FullEdge> sortedEdges = new List<FullEdge>();
        static List<FullEdge> allEdgesAfterKrusk = new List<FullEdge>();
        static MathGraph minimalGlob = new MathGraph();
        static MathGraph dataForPrime = new MathGraph();
        static List<NormalGraph> klastResult = new List<NormalGraph>();
        static int countOfNodes = 0;
        static List<Friend> friendsGlob = new List<Friend>();

        public static void clear()
        {
            Trees = new List<NormalGraph>();
            sortedEdges = new List<FullEdge>();
            allEdgesAfterKrusk = new List<FullEdge>();
            minimalGlob = new MathGraph();
            dataForPrime = new MathGraph();
            klastResult = new List<NormalGraph>();
            countOfNodes = 0;
            friendsGlob = new List<Friend>();
        }

        public static void buildFullGraph(List<Friend> friends)
        {
            countOfNodes = friends.Count;
            friendsGlob = friends;
            MathGraph graph = new MathGraph();
            List<Node> nodes = new List<Node>();

            foreach (Friend friend in friends)
            {
                Node node = new Node();
                node.friend = friend;
                nodes.Add(node);
            }
            graph.nodes = nodes;
            
            for (int i = 0; i < graph.nodes.Count(); i++)
                for (int j = i + 1; j < graph.nodes.Count(); j++)
                {
                    FullEdge fe = new FullEdge();
                    fe.from = i;
                    fe.to = j;
                    fe.weight = getDistance(graph.nodes[i].friend, graph.nodes[j].friend);
                    sortedEdges.Add(fe);
                }

            sortedEdges = sortedEdges.OrderBy(s => s.weight).ToList();
        }


        public static void buildMinimalTreeKruskal()
        {
            MathGraph Minimal = new MathGraph();
            for (int i = 0; i < countOfNodes; i++)
                Minimal.nodes.Add(new Node());
            for (int i = 0; i < sortedEdges.Count(); ++i)
            {
                pair tempTo = new pair();
                tempTo.num = sortedEdges[i].to;
                tempTo.weight = sortedEdges[i].weight;
                Minimal.nodes[sortedEdges[i].from].pairs.Add(tempTo);
                Minimal.nodes[sortedEdges[i].from].friend = friendsGlob[sortedEdges[i].from];
                pair tempFr = new pair();
                tempFr.num = sortedEdges[i].from;
                tempFr.weight = sortedEdges[i].weight;
                Minimal.nodes[sortedEdges[i].to].pairs.Add(tempFr);
                Minimal.nodes[sortedEdges[i].to].friend = friendsGlob[sortedEdges[i].to];
                int[] used = new int[countOfNodes];

                if (!dfs(sortedEdges[i].from, sortedEdges[i].from, Minimal, used))
                {
                    Minimal.nodes[sortedEdges[i].from].pairs.Remove(tempTo);
                    Minimal.nodes[sortedEdges[i].to].pairs.Remove(tempFr);
                }
                else
                    allEdgesAfterKrusk.Add(sortedEdges[i]);
            }
            minimalGlob = Minimal;
        }

        public static void splitArray(int count)
        {
            count = Math.Min(count, countOfNodes);
            MathGraph tempSplit = (MathGraph)minimalGlob.Clone();
            List<FullEdge> tempAllEdges = allEdgesAfterKrusk.OrderBy(s => s.weight).ToList();

            for (int i = 0; i < count - 1; ++i)
            {
                for (int j = 0; j < tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].from].pairs.Count; ++j)
                {
                    if (((tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].from].pairs[j].num == tempAllEdges.Last().from)
                        || (tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].from].pairs[j].num == tempAllEdges.Last().to))
                        && (tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].from].pairs[j].weight == tempAllEdges.Last().weight))
                    {
                        tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].from].pairs.RemoveAt(j);
                        break;
                    }
                }
                for (int j = 0; j < tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].to].pairs.Count; ++j)
                {
                    if (((tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].to].pairs[j].num == tempAllEdges.Last().from)
                        || (tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].to].pairs[j].num == tempAllEdges.Last().to))
                        && (tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].to].pairs[j].weight == tempAllEdges.Last().weight))
                    {
                        tempSplit.nodes[tempAllEdges[tempAllEdges.Count - 1].to].pairs.RemoveAt(j);
                        break;
                    }
                }
                tempAllEdges.Remove(tempAllEdges.Last());
            }
            int colour = 1;
            int[] used = new int[tempSplit.nodes.Count];
            for (int i = 0; i < tempSplit.nodes.Count; ++i)
            {
                if (used[i] == 0)
                {
                    dfsClast(i, i, tempSplit, used, colour);
                    colour++;
                }
            }
            
            for (int i = 1; i < colour; ++i)
            {

                NormalGraph oneTree = new NormalGraph();
                for (int j = 0; j < tempSplit.nodes.Count; ++j)
                {

                    if (used[j] == i)
                    {
                        if (tempSplit.nodes[j].pairs.Count == 0)
                        {
                            oneTree.nodes.Add(friendsGlob[j]);
                        }
                        else
                            for (int k = 0; k < tempSplit.nodes[j].pairs.Count; ++k)
                            {
                                int start = new int();
                                int end = new int();
                                double weight = new double();
                                start = j;
                                end = tempSplit.nodes[j].pairs[k].num;
                                weight = tempSplit.nodes[j].pairs[k].weight;

                                Edge ed = new Edge();
                                ed.start = friendsGlob[start];
                                ed.end = friendsGlob[end];
                                ed.weight = weight;
                                oneTree.edges.Add(ed);
                                
                                oneTree.nodes.Add(friendsGlob[start]);
                                oneTree.nodes.Add(friendsGlob[end]);
                            }
                    }
                }

                oneTree.edges = oneTree.edges.OrderBy(e => e.weight).ToList();
                for (int z = 1; z < oneTree.edges.Count; oneTree.edges.RemoveAt(z++));
                oneTree.nodes = oneTree.nodes.Distinct().ToList();
                Trees.Add(oneTree);
                
            }
        }
        
        private static void dfsClast(int cur, int from, MathGraph Minimal, int[] used, int clr)
        {
            used[cur] = clr;
            for (int i = 0; i < Minimal.nodes[cur].pairs.Count(); ++i)
            {
                if (used[Minimal.nodes[cur].pairs[i].num] == clr
                    && Minimal.nodes[cur].pairs[i].num != from)
                {
                    return;
                }
                else if (Minimal.nodes[cur].pairs[i].num != from)
                {
                    dfsClast(Minimal.nodes[cur].pairs[i].num, cur, Minimal, used, clr);
                }
            }
            return;
        }

        public static List<NormalGraph> getSplittedGraph()
        {
            return Trees;
        }

        public static NormalGraph getNormalGraph()
        {
            NormalGraph ng = new NormalGraph();
            ng.nodes = friendsGlob;
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < countOfNodes; ++i)
                for (int j = 0; j < minimalGlob.nodes[i].pairs.Count(); ++j)
                {
                    int start = new int();
                    int end = new int();
                    double weight = new double();
                    if (minimalGlob.nodes[i].pairs[j].num > i)
                    {
                        start = i;
                        end = minimalGlob.nodes[i].pairs[j].num;
                        weight = minimalGlob.nodes[i].pairs[j].weight;


                        Edge ed = new Edge();
                        ed.start = friendsGlob[start];
                        ed.end = friendsGlob[end];
                        ed.weight = weight;
                        edges.Add(ed);
                    }
                }
            edges = edges.OrderBy(e => e.weight).ToList();
            ng.edges = edges;

            return ng;
        }

        private static bool dfs(int cur, int from, MathGraph Minimal, int[] used)
        {
            for (int i = 0; i < Minimal.nodes[cur].pairs.Count(); ++i)
            {
                if (used[Minimal.nodes[cur].pairs[i].num] == 1
                    && Minimal.nodes[cur].pairs[i].num != from)
                {
                    return false;
                }
                else if (Minimal.nodes[cur].pairs[i].num != from)
                {
                    used[Minimal.nodes[cur].pairs[i].num] = 1;
                    if (!dfs(Minimal.nodes[cur].pairs[i].num, cur, Minimal, used))
                        return false;
                }
            }
            return true;
        }

        private static double getDistance(Friend first, Friend second)
        {
            return Math.Sqrt((second.MusicCount - first.MusicCount) *
                (second.MusicCount - first.MusicCount) +
                (second.FriendsCount - first.FriendsCount) *
                (second.FriendsCount - first.FriendsCount));
        }
    }
}
