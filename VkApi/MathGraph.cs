using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
   

    class MathGraph : ICloneable
    {
        public List<Node> nodes = new List<Node>();

        public object Clone()
        {
            MathGraph mg = new MathGraph();
            foreach(Node n in this.nodes)
            {
                mg.nodes.Add(n);
            }
            return mg;
        }
    }

    
    struct pair
    {
        public int num;
        public double weight;
    }

    struct FullEdge
    {
        public int from;
        public int to;
        public double weight;
    }

    class Node
    {
        public Friend friend;
        public List<pair> pairs = new List<pair>();
    }
}
