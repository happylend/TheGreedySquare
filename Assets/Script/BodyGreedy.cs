using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyGreedy : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameObject.transform.parent.GetComponent<Greedy>().speed == 0 && gameObject.transform.parent.GetComponent<Greedy>().greedy_flag == 0)
        {
            if (gameObject.transform.parent.GetComponent<Greedy>().leftwin == 1 && gameObject.transform.parent.GetComponent<Greedy>().rightwin == 1)
            {
                gameObject.transform.parent.GetComponent<Greedy>().win = 1;
            }
            else
            {
                GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
                GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
                GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
                GameObject.Find("GameObject").SendMessage("upwall");
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "CubeRight(Clone)")
        {
            Debug.Log("BodyCol");
            gameObject.transform.parent.GetComponent<Greedy>().speed = 0;
            gameObject.transform.parent.GetComponent<Greedy>().greedy_flag = 0;

            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;

            gameObject.transform.parent.GetComponent<Greedy>().rightwin = 1;
            print(gameObject.transform.parent.GetComponent<Greedy>().rightwin);
        }

        if (other.gameObject.name == "CubeLeft(Clone)" || other.gameObject.name == "LeftCube")
        {
            Debug.Log("BodyCol");
            gameObject.transform.parent.GetComponent<Greedy>().speed = 0;
            gameObject.transform.parent.GetComponent<Greedy>().greedy_flag = 0;

            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;

            gameObject.transform.parent.GetComponent<Greedy>().leftwin = 1;
            print(gameObject.transform.parent.GetComponent<Greedy>().leftwin);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        //碰到底部
        if (col.gameObject.tag == "Wall")
        {
            gameObject.transform.parent.GetComponent<Greedy>().Coll = 1;
            Debug.Log("BodyCol");
            gameObject.transform.parent.GetComponent<Greedy>().speed = 0;
            gameObject.transform.parent.GetComponent<Greedy>().greedy_flag = 0;

            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
        }

        if (col.gameObject.name == "LeftWall")
            gameObject.transform.parent.GetComponent<Greedy>().left_move = 0;
        if (col.gameObject.name == "RightWall")
            gameObject.transform.parent.GetComponent<Greedy>().right_move = 0;

        //碰到底部岩石
        if (col.gameObject.name == "CubeRight(Clone)" || col.gameObject.name == "RightCube")
        {
            Debug.Log("BodyCol");
            gameObject.transform.parent.GetComponent<Greedy>().Coll = 1;
            gameObject.transform.parent.GetComponent<Greedy>().speed = 0;
            gameObject.transform.parent.GetComponent<Greedy>().greedy_flag = 0;

            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
        }

        if (col.gameObject.name == "CubeLeft(Clone)" || col.gameObject.name == "LeftCube")
        {
            Debug.Log("BodyCol");
            gameObject.transform.parent.GetComponent<Greedy>().Coll = 1;
            gameObject.transform.parent.GetComponent<Greedy>().speed = 0;
            gameObject.transform.parent.GetComponent<Greedy>().greedy_flag = 0;

            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
        }
    }
}
