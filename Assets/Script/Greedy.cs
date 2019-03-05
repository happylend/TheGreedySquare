using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greedy : MonoBehaviour {
    public int speed=8;
    public int greedy_flag = 1;
	public int left_move=1;
    public int right_move =1;

    Vector3 up = new Vector3(0, 1, 0);
    Vector3 down = new Vector3(0, -1, 0);
    Vector3 left = new Vector3(-1, 0, 0);
    Vector3 right = new Vector3(1, 0, 0);
    Vector3 now;

    public int rightwin = 0;
    public int leftwin = 0;
    public int win = 0;
    public int Coll = 0;

    float timer = 0f;
    public float timerGap = 0.2f;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (greedy_flag == 1)
        {
			if (Input.GetKeyDown(KeyCode.A) && left_move==1)
            {
				right_move = 1;
				transform.position = 1 * left + transform.position;

            }
			if (Input.GetKeyDown(KeyCode.D) && right_move==1)
            {
				left_move=1;
				transform.position = 1 * right + transform.position;

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                timerGap = 0.1f;

            }

            timer += Time.deltaTime;

            if (timer > timerGap)
            {
                Vector3 tmpPosition = transform.position;
                List<Vector3> tmpList = new List<Vector3>();
                timer = 0;
                
				transform.position = 1 * down + transform.position;
            }
        }
        //this.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    //左右两侧岩石
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CubeRight(Clone)" || other.gameObject.name == "RightCube")
        {
            greedy_flag = 0;
            speed = 0;
            rightwin = 1;
            print(rightwin);
            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
        }
        if (other.gameObject.name == "CubeLeft(Clone)" || other.gameObject.name == "LeftCube")
        {
            greedy_flag = 0;
            speed = 0;
            leftwin = 1;
            print(leftwin);
            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
        }
    }

    //碰撞检测
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Coll = 1;
            Debug.Log("SnakeCol");
            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
            greedy_flag = 0;
            speed = 0;
            if (leftwin == 1 && rightwin == 1)
            {
                win = 1;
            }
            else
            {
                //底部和岩石上移
                GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
                GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
                GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
                GameObject.Find("GameObject").SendMessage("upwall");
            }
                //Application.LoadLevel("GameOver");
        }

		if (col.gameObject.name == "LeftWall")
			left_move = 0;
		if (col.gameObject.name == "RightWall")
			right_move = 0;

        if (col.gameObject.name == "CubeRight(Clone)" || col.gameObject.name == "RightCube")
        {
            Coll = 1;
            greedy_flag = 0;
            speed = 0;
            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
            GameObject.Find("GameObject").SendMessage("upwall");
        }
        if (col.gameObject.name == "CubeLeft(Clone)" || col.gameObject.name == "LeftCube")
        {
            Coll = 1;
            greedy_flag = 0;
            speed = 0;
            GameObject.Find("GameObject").GetComponent<Food>().food_flag = 1;
            GameObject.Find("GameObject").GetComponent<RandomSnake>().randomSnake_flag = 1;
            GameObject.Find("time").GetComponent<CountDown>().TotalTime = 3;
            GameObject.Find("GameObject").SendMessage("upwall");
        }
    }

    
}