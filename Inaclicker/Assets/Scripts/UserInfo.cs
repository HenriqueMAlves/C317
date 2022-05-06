using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    //
    // Resumo:
    //     `Users` is a class that stores Player informations between game sessions.
    //     It can store string, float and integer values into the user’s platform registry.
    public static class Users
    {
        public static List<UserInfo> users = new List<UserInfo>();
    }
    
    public class UserInfo
    {
        public static string name { get; set; }
        public static int score { get; set; }
        public static int rank { get; set; }

        public UserInfo(string name, int score, int rank)
        {
            UserInfo.name = name;
            UserInfo.score = score;
            UserInfo.rank = rank;
        }
    }
}