using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
    public GameObject camera0;
    public GameObject camera1;
    public GameObject Canvas;
    // Use this for initialization

    void Awake()
    {
        camera0.active = false;
        camera1.active = true;
        Canvas.active = true;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V) && camera0.active == false)
        {
            camera0.active = true;
            camera1.active = false;
            Canvas.active = false;
        }
        else if(Input.GetKeyDown(KeyCode.V) && camera1.active == false)
        {
            camera0.active = false;
            camera1.active = true;
            Canvas.active = true;
        }

    }
}
