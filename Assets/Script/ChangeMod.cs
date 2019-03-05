using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMod : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.tag == "Snake")
        {
            other.transform.name = "greedy";
            other.transform.GetComponent<Greedy>().enabled = true;
            other.transform.GetComponent<Snake>().enabled = false;
            Destroy(other.gameObject);
        }
    }
}
