using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpWall : MonoBehaviour {
    float u = 0.9f;
    float p = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void upwall()
    {
        GameObject.Find("GameTime").transform.localScale = new Vector3(1, u, 1);
        GameObject.Find("Flag").transform.position = new Vector3(0, p, 0);
        u = u-0.1f;
        p = p+3;
        GameObject.Find("Life").GetComponent<Life>().life = GameObject.Find("Life").GetComponent<Life>().life - 1;
    }
}
