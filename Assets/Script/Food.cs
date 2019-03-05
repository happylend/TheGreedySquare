using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

    public GameObject SSFood;
    public int xLimit = 30;    //游戏边界（最大宽度）
    public int yLimit = 22;    //高度位置
    public int food_flag = 1;
    void Start () {
        InvokeRepeating("ShowFood", 1, 4);
	}
	
	// Update is called once per frame
	void Update () {
	    if(food_flag == 1)
        {
            int x = Random.Range(-xLimit, xLimit);
            int y = yLimit;
            Instantiate(SSFood, new Vector2(x, y), Quaternion.identity);
            food_flag = 0;
        }
	}
    void ShowFood()
    {

    }
}
