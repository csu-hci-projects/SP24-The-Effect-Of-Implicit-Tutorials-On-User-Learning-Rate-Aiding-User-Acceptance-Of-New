using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTracking : MonoBehaviour
{
    float timer;
    bool timerActive = false;

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timer += Time.deltaTime;
        }
    }

    void StartTask()
    {
        timerActive = true;
        timer = 0.0f;
    }

    void EndTask()
    {
        timer += Time.deltaTime;
        timerActive = false;
    }
}
