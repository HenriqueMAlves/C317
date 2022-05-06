using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_button : MonoBehaviour
{
    public string nextScene;

    void Start()
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
    }

    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
