using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime;
    ok=0;
    public Text countdownText;

    void Start()
    {   
        
    }


    void Update()
    {
        if (ok == 0)
        {
            currentTime = 20f;
            ok = 1;
        }
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        if (currentTime <= 0)
            SceneManager.LoadScene("Lose");

    }
}
