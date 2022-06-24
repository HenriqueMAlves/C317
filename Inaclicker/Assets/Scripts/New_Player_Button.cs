using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class New_Player_Button : MonoBehaviour
{
    public string nextScene;
    public Sprite defaultBackground;
    public Sprite defaultTable;
    public Sprite defaultWall;
    private string playerName;

    void Start()
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
    }

    public void changeScene()
    {
        playerName = GameObject.Find("Entrada Nome").GetComponent<InputField>().text;
        if (playerName.Length > 0)
        {
            int i = 0;
            bool flagUser = false;
            UserInfo newUser = new UserInfo(playerName, 0, 0, 0);

            foreach (UserInfo user in User.users)
            {
                print(user.name);
                //print("rank: " + user.rank);
                print("score: " + user.score);
                //print("wall: " + user.wall);
                //print("table: " + user.table);
                //print("backgeound: " + user.background);
                print("user número: " + i);
                if (newUser.name.Equals(user.name))
                {
                    print("Danada");
                    print("numero: " + i);
                    flagUser = true;
                }
                i++;
            }
            if(flagUser == false)
            {
                User.users.Add(newUser);
                User.users[i].name = playerName;
                User.users[i].score = 0;
                User.users[i].rank = 0;
                User.users[i].background = defaultBackground;
                User.users[i].table = defaultTable;
                User.users[i].wall = defaultWall;
                PlayerPrefs.SetInt("actualPlayerId", i);
                print("novo user número: " + i);
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
