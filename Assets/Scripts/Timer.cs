using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = "00 : 00";
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.timeSinceLevelLoad;
        timer.text = "Time = " + TimeType(time);
    }

    string TimeType(float time)
    {
        float min = Mathf.FloorToInt( time / 60 );
        string minString = min.ToString();
        float sec = Mathf.FloorToInt( time % 60 );
        string secString = sec.ToString();
        if (sec < 10)
        {
            secString = "0" + secString;
        }
        if (min < 10)
        {
            minString = "0" + minString;
        }

        return minString + " : " + secString;
    }
}
