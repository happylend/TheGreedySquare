using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSnake : MonoBehaviour {
    public int randomSnake_flag = 1;
    public Rigidbody Snake;
    public float CreatTime = 3f;
    public int xLimit = 8;    //游戏边界（最大宽度）
    public int y = 20;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(randomSnake_flag == 1)
        {
            int x = Random.Range(-xLimit, xLimit);
            CreatTime -= Time.deltaTime;    //开始倒计时
            if (CreatTime <= 0)    //如果倒计时为0 的时候
            {
                Instantiate(Snake, new Vector2(x, y), Quaternion.identity);
                CreatTime = 3f;
                randomSnake_flag = 0;
                GameObject.Find("GameObject").GetComponent<NewCube>().start = 1;
                GameObject.Find("Snake").GetComponent<Greedy>().Coll = 0;
            }
        }

	}
}
