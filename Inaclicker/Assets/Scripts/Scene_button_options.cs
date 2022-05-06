using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_button_options : MonoBehaviour
{
    public string nextScene;

    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
