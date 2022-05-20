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
    }

    public void countPoint()
    {
        User.users[0].score++;
        GameObject.Find("Pontos Num").GetComponent<Text>().text = User.users[0].score.ToString();
    }
}
