using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    //
    // Resumo:
    //     `Users` is a class that stores Player informations between game sessions.
    //     It can store string, float and integer values into the user’s platform registry.
    public class UserInfo
    {
        public UserInfo() { }
        public string name { get; set; }
        public int score { get; set; }
        public int rank { get; set; }
        public int index { get; set; }

        public UserInfo(string name, int score, int rank, int index)
        {
            this.name = name;
            this.score = score;
            this.rank = rank;
            this.index = index;
        }
    }

    public class User
    {
        public static List<UserInfo> users = new List<UserInfo>();
    }
}