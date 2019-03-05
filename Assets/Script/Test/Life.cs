using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public GameObject text;
    public int life = 5;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () { 
        GetComponent<Text>().text = "" + life;
        if(life==0)
        {
            Application.LoadLevel("GameOver");
        }
    }
}
