using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VkApi
{
    public class apiWorker
    {
        private string token;
        private int _frCnt = -1;
        public int FriendsCount { get { getFriendsId(); return _frCnt; } }

        public apiWorker(string accesToken)
        {
            if (accesToken != null)
                token = accesToken;
        }

        public static List<Friend> getFriendsFromJsonFile(string filePath)
        {
            List<Friend> friends = new List<Friend>();

            if (File.Exists(filePath))
            {
                JObject file = JObject.Parse(File.ReadAllText(filePath));
                foreach (JObject friend in file["friends"])
                {
                    Friend lf = friend.ToObject<Friend>();
                    try
                    {
                        lf.MusicCount = friend["counters"]["audios"].ToObject<int>();
                        lf.FriendsCount = friend["counters"]["friends"].ToObject<int>();
                    }
                    catch (Exception ex) { }

                    if (lf.Photo != null && lf.MusicCount > 1 && lf.FriendsCount > 1)
                        friends.Add(lf);
                }
                return friends;
            }

            return null;
        }
        public JObject getUserInfo()
        {
            return sendRequest("https://api.vk.com/method/users.get?v=5.7.3&fields=photo_200&access_token=" + token);
        }

        public List<string> getFriendsId()
        {
            List<string> result = new List<string>();
            JObject friends = sendRequest("https://api.vk.com/method/friends.get?v=5.7.3&order=random&access_token=" + token);

            if (friends != null)
                result = friends["response"]["items"].ToObject<List<string>>();
            _frCnt = result.Count;
            return result;
        }

        public void getFriendsToFile(int count, string filePath, UpdateControl upCon = null)
        {
            List<string> Ids = getFriendsId();
            Ids.RemoveRange(count, Ids.Count - count);

            JArray jar = new JArray();
            JObject obj = new JObject();

            upCon(0, Ids.Count, true);

            int counter = 1;
            foreach (string id in Ids)
            {
                JObject user = sendRequest("https://api.vk.com/method/users.get?v=5.7.3&fields=photo_200,counters&access_token=" + token + "&user_ids=" + id);

                if (user["error"] != null)
                {
                    for (int i = 0; i < 10; i++)
                        if (user["error"] != null)
                        {
                            Thread.Sleep(1000);
                            user = sendRequest("https://api.vk.com/method/users.get?v=5.7.3&fields=photo_200,counters&access_token=" + token + "&user_ids=" + id);
                        }
                        else
                            break;
                }

                if (user["response"] != null)
                    jar.Add(user["response"][0]);

                upCon(counter++, Ids.Count);
            }


            obj["friends"] = jar;

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private JObject sendRequest(string request)
        {
            JObject result;
            try
            {
                WebRequest req = WebRequest.Create(request);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string Out = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject(Out) as JObject;
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}