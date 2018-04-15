using Newtonsoft.Json;
using System;
using System.Drawing;

namespace VkApi
{
    public class Friend
    {
        [JsonProperty ("first_name")]
        public string FirstName;

        [JsonProperty ("last_name")]
        public string LastName;

        [JsonProperty("id")]
        public long UserId;

        public int MusicCount = 0;

        public int FriendsCount = 0;

        [JsonProperty("photo_200")]
        public Uri Photo;

        public Color clr;
        public Friend(string name, string lastName, long userId, 
            int musicCount, int friendsCount, Uri photo)
        {
            FirstName = name;
            LastName = lastName;
            UserId = userId;
            MusicCount = musicCount;
            FriendsCount = friendsCount;
            Photo = photo;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, music: {2}, friends: {3}", 
                FirstName, LastName, MusicCount, FriendsCount);
        }
    }
}
