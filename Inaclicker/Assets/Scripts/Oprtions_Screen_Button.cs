using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oprtions_Screen_Button : MonoBehaviour
{
    private int __lastScreenInfo;
    enum scenes{
        initialScreen,
        createUser,
        game,
        options,
        ranking,
        store
    }

    void Start()
    {
        __lastScreenInfo = PlayerPrefs.GetInt("lastLevel");
        if (__lastScreenInfo == (int)scenes.game)
        {
            GameObject.Find("Voltar").GetComponentInChildren<Text>().text = "Voltar";
        }
        else if (__lastScreenInfo == (int)scenes.initialScreen)
        {
            GameObject.Find("Voltar").GetComponentInChildren<Text>().text = "Voltar ao Menu";
        }
    }
    public void changeScene()
    {
        __lastScreenInfo = PlayerPrefs.GetInt("lastLevel");
        if (__lastScreenInfo == (int)scenes.game)
        {
            SceneManager.LoadScene("Game");
        }
        else if (__lastScreenInfo == (int)scenes.initialScreen)
        {
            SceneManager.LoadScene("Initial_Screen");
        }
        
    }
}
