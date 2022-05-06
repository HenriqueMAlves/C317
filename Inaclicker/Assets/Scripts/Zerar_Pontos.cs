using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zerar_Pontos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("playerPoints", 0);
    }
}
