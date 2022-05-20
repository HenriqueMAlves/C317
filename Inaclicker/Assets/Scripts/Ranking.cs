using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Nome").GetComponentInChildren<Text>().text = User.users[0].name;
        GameObject.Find("pontos").GetComponentInChildren<Text>().text = User.users[0].score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
