using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_button : MonoBehaviour
{
    public string nextScene;
    public string thisScene;
    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
        //SceneManager.UnloadScene(thisScene);
    }
}
