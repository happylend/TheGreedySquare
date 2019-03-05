using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCube : MonoBehaviour {
    public List<Vector3> way = new List<Vector3>();
    public GameObject Rcube;
    public GameObject Lcube;
    public GameObject right_cube;
    public GameObject left_cube;

    public int xLimit = 30;    //游戏边界（最大宽度）
    public int yLimit = 22;    //高度位置
    public int food_flag = 1;
    int i, num_right, num_left;

    public int start = 0;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (start == 1)
        {
            num_right = Random.Range(0, 18);
            num_left = Random.Range(14 - num_right, 18 - num_right);

            List<GameObject> cube_right = new List<GameObject>();
            // Use this for initialization
            for (i = 0; i < num_right; ++i)
            {
                GameObject container = GameObject.Find("RightCube");
                GameObject newcube_right = Instantiate(Rcube, right_cube.transform.position - (i + 1) * new Vector3(1f, 0, 0), Quaternion.identity) as GameObject;
                cube_right.Add(newcube_right);
            }

            List<GameObject> cube_left = new List<GameObject>();
            // Use this for initialization
            for (i = 0; i < num_left; ++i)
            {
                GameObject container = GameObject.Find("RightCube");
                GameObject newcube_left = Instantiate(Lcube, left_cube.transform.position - (i + 1) * new Vector3(-1f, 0, 0), Quaternion.identity) as GameObject;
                cube_left.Add(newcube_left);
            }
            start = 0;
        }

    }

}
