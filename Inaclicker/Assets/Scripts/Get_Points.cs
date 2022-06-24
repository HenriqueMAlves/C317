using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Get_Points : MonoBehaviour
{
    void Start()
    {
        int playerId = PlayerPrefs.GetInt("actualPlayerId");
        GameObject.Find("Pontos Num").GetComponent<Text>().text = User.users[playerId].score.ToString();
        //if(PlayerPrefs.GetInt("lastLevel") != 2)//Se veio da tela Game
        {
            GameObject.Find("BackGround").GetComponent<Image>().sprite = User.users[playerId].background;
            GameObject.Find("Table").GetComponent<Image>().sprite = User.users[playerId].table;
            GameObject.Find("Wall").GetComponent<Image>().sprite = User.users[playerId].wall;
        }
    }

    public void countPoint()
    {
        int playerId = PlayerPrefs.GetInt("actualPlayerId");
        User.users[playerId].score++;
        GameObject.Find("Pontos Num").GetComponent<Text>().text = User.users[playerId].score.ToString();
    }
}
