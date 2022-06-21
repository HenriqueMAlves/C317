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
            User.users.Add(new UserInfo(playerName, 0, 0, 0));
            User.users[0].name = playerName;
            User.users[0].score = 0;
            User.users[0].rank = 0;
            User.users[0].background = defaultBackground;
            User.users[0].table = defaultTable;
            User.users[0].wall = defaultWall;
            SceneManager.LoadScene(nextScene);
        }
    }
}
