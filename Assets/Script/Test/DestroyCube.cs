using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour {
	// Use this for initialization
	void Start () {
        GameObject.Find("DownSnakeWall").GetComponent<Destroy>().snakedie = 0;
        GameObject.Find("RightSnakeWall").GetComponent<Destroy>().snakedie = 0;
        GameObject.Find("LeftSnakeWall").GetComponent<Destroy>().snakedie = 0;
        GameObject.Find("TopSnakeWall").GetComponent<Destroy>().snakedie = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("DownSnakeWall").GetComponent<Destroy>().snakedie == 1 || GameObject.Find("RightSnakeWall").GetComponent<Destroy>().snakedie == 1 || GameObject.Find("LeftSnakeWall").GetComponent<Destroy>().snakedie == 1 || GameObject.Find("TopSnakeWall").GetComponent<Destroy>().snakedie == 1)
        {
            GameObject.Destroy(gameObject);
            GameObject.Destroy(GameObject.Find("greedy"));
            GameObject.Find("DownSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("RightSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("LeftSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("TopSnakeWall").GetComponent<Destroy>().snakedie = 0;
        }

        if (GameObject.Find("greedy").GetComponent<Greedy>().win == 1)
            {
                GameObject.Destroy(gameObject);
                GameObject.Destroy(GameObject.Find("greedy"));
                GameObject.Find("Score").GetComponent<Source>().sorce = GameObject.Find("Score").GetComponent<Source>().sorce + 100;
                GameObject.Find("DownSnakeWall").GetComponent<Destroy>().snakedie = 0;
                GameObject.Find("RightSnakeWall").GetComponent<Destroy>().snakedie = 0;
                GameObject.Find("LeftSnakeWall").GetComponent<Destroy>().snakedie = 0;
                GameObject.Find("TopSnakeWall").GetComponent<Destroy>().snakedie = 0;
            }

        if (GameObject.Find("greedy").GetComponent<Greedy>().Coll == 1)
        {
            GameObject.Destroy(gameObject);
            GameObject.Destroy(GameObject.Find("greedy"));
            GameObject.Find("DownSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("RightSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("LeftSnakeWall").GetComponent<Destroy>().snakedie = 0;
            GameObject.Find("TopSnakeWall").GetComponent<Destroy>().snakedie = 0;
        }


    }
}
