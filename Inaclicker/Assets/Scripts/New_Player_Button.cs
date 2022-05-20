using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class New_Player_Button : MonoBehaviour
{
    public string nextScene;
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
            SceneManager.LoadScene(nextScene);
        }
    }
}
