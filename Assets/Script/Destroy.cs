using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public int snakedie = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag == 1)
        {
            snakedie = 1;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snake")
        {
            Debug.Log("2");

            GameObject.Destroy(other.gameObject);
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
            
        }
    }

    void OnCollisionEnter(Collision other)
    {

        
    }
}
