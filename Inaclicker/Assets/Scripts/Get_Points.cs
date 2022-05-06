using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Get_Points : MonoBehaviour
{
    private int points;

    void Start()
    {
        points = PlayerPrefs.GetInt("playerPoints");
        GameObject.Find("Pontos Num").GetComponent<Text>().text = points.ToString();
    }

    public void countPoint()
    {
        points++;
        GameObject.Find("Pontos Num").GetComponent<Text>().text = points.ToString();
        PlayerPrefs.SetInt("playerPoints", points);
    }
}
