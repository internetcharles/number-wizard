using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        UnityEngine.Debug.Log("Welcome to Number Wizard... I want to guess your freakin number.");
        UnityEngine.Debug.Log("Pick a number!");
        UnityEngine.Debug.Log($"Highest number is: {max}");
        UnityEngine.Debug.Log($"Lowest number is: {min}");
        UnityEngine.Debug.Log($"Tell me if your number is higher or lower than {guess}");
        UnityEngine.Debug.Log("Push up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UnityEngine.Debug.Log($"Is your guess lower or higher than {guess}. Press up/down!");
            min = guess;
            guess = (max + min) / 2;
            UnityEngine.Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            UnityEngine.Debug.Log($"Is your guess lower or higher than {max}. Press up/down!");
            max = guess;
            guess = (max + min) / 2;
            UnityEngine.Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            UnityEngine.Debug.Log("Return key was pressed.");
        }


    }
}
