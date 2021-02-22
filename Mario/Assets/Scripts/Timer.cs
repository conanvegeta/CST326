using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    float timeLeft = 400.0f;
    public Text time;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        time.text = "" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}