using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ranking : MonoBehaviour
{
    string[] positions = {
        "Rank",
        "Rank1",
        "Rank2",
        "Rank3",
        "Rank4",
        "Rank5",
        "Rank6",
        "Rank7",
        "Rank8",
        "Rank9",
    };
    List<int> playerPosition = new List<int>();

    void Start()
    {
        int i = 0;

        SortPlayers();

        foreach(int player in playerPosition)
        {
            
            print("Posição do ranking -----> " + positions[i] + "/Nome");
            print("Nome do player atual --------> " + User.users[player].name);
            GameObject.Find(positions[i]+"/Nome").GetComponentInChildren<Text>().text = User.users[player].name;
            GameObject.Find(positions[i]+"/pontos").GetComponentInChildren<Text>().text = User.users[player].score.ToString();
            i++;
        }
        for (; i < positions.Length; i++)
        {
            GameObject.Find(positions[i]).SetActive(false);
        }
        /*GameObject.Find("Rank").SetActive(true);
        GameObject.Find("Nome").GetComponentInChildren<Text>().text = User.users[0].name;
        GameObject.Find("pontos").GetComponentInChildren<Text>().text = User.users[0].score.ToString(); */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SortPlayers()
    {
        int i = 0;
        int j = 0;
        List<int> playerScore = new List<int>();

        foreach(UserInfo user in User.users)
        {
            playerScore.Add(user.score);
            print("++++++++++++++++++++ player score:" + user.score);
        }

        playerScore.Sort((a, b) => b.CompareTo(a));
        playerScore.ForEach((element) => {
            print("*************************"+element);
            });

        print("Lista ordenada de players: ");
        j = 0;
        foreach(int actualPosition in playerScore)
        {
            i = 0;
            foreach (UserInfo user in User.users)
            {
                if(actualPosition == user.score)
                {
                    playerPosition.Add(i);
                    print("---> " + i);
                }
                i++;
            }
            j++;
        }
    }
}
