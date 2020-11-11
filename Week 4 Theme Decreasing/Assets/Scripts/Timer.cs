using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float currentTime = 0f;
    float startingTime = 10f;


    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        if (currentTime <= 0)
            SceneManager.LoadScene("Lose");

    }
}
