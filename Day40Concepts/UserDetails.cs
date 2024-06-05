using System;
using System.Collections.Generic;

namespace Day40Concepts
{
    public class UserDetails
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User(){ id=1, userName="admin", password="admin" },
                new User(){ id=2, userName="mark", password="mark" },
                new User(){ id=3, userName="kim", password="kim" },
                new User(){ id=4, userName="john", password="john" }

            };

            return users;
        }
    }
}
