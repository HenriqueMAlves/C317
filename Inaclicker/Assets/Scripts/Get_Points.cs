using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Get_Points : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Pontos Num").GetComponent<Text>().text = User.users[0].score.ToString();
        //if(PlayerPrefs.GetInt("lastLevel") != 2)//Se veio da tela Game
        {
            GameObject.Find("BackGround").GetComponent<Image>().sprite = User.users[0].background;
            GameObject.Find("Table").GetComponent<Image>().sprite = User.users[0].table;
            GameObject.Find("Wall").GetComponent<Image>().sprite = User.users[0].wall;
        }
    }

    public void countPoint()
    {
        User.users[0].score++;
        GameObject.Find("Pontos Num").GetComponent<Text>().text = User.users[0].score.ToString();
    }
}
