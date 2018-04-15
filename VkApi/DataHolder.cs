using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApi
{
    static public class DataHolder
    {
        public static List<Friend> friends = null;
        public static apiWorker api = null;
        public static string jsonFilePath = null;
        public static NormalGraph fullGraph = null;
        public static List<NormalGraph> splittedGraph = null;
    }
}
