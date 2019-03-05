using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject text;
    public int TotalTime = 5;
    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = "" + TotalTime;
        InvokeRepeating("TimeChange", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TimeChange()
    {
        if (TotalTime > 0)
        {
            TotalTime--;
            GetComponent<Text>().text = "" + TotalTime;
        }

    }
}
