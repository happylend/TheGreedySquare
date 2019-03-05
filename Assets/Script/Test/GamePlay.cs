using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour {
    int TimeEnd = 0;
    public GameObject HowToPlay;
    public GameObject GameInformation;
	// Use this for initialization
	void Start () {
        HowToPlay.SetActiveRecursively(true);
        GameInformation.SetActiveRecursively(true);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && TimeEnd == 0)
        {
            HowToPlay.SetActiveRecursively(true);
            GameInformation.SetActiveRecursively(true);
            Time.timeScale = 0;
            TimeEnd = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && TimeEnd == 1)
        {
            HowToPlay.SetActiveRecursively(false);
            GameInformation.SetActiveRecursively(false);
            Time.timeScale = 1;
            TimeEnd = 0;
        }

    }
}
