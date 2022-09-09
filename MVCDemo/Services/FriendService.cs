﻿using MVCDemo.Models;

namespace MVCDemo.Servics
{
    public class FriendService
    {
        static List<Friend> Friends { get; }
        static int nextId = 4;
        static FriendService()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendId = 1, FriendName = "Neha", Place="Banglore" },
                    new Friend { FriendId = 2, FriendName = "Reema Gowda", Place="Hubli" },
                    new Friend {FriendId = 3, FriendName = "Seema", Place="Dharwad" },
                    new Friend {FriendId = 3, FriendName = "Ammu", Place="Honnavar" },
                    new Friend {FriendId = 3, FriendName = "Nancy", Place="Nelamagla" }
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(f => f.FriendId == id);

        public static void Add(Friend friend)
        {
            friend.FriendId = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }

        public static void Update(Friend friend)
        {
            var index = Friends.FindIndex(f => f.FriendId == friend.FriendId);
            if (index == -1)
                return;

            Friends[index] = friend;
        }

    }
}
