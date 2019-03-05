using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour {
    public GameObject body;

    Vector3 up = new Vector3(0, 1, 0);
    Vector3 down = new Vector3(0, -1, 0);
    Vector3 left = new Vector3(-1, 0, 0);
    Vector3 right = new Vector3(1, 0, 0);
    Vector3 now;
    public int speed = 2;


    float timer = 0f;
    public float timerGap = 0.5f;

    List<GameObject> snakeBody = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        //创建身体
        for (int i = 0; i < 3; ++i)
        {
            GameObject container = GameObject.Find("Snake(Clone)");
            GameObject newbodynext = Instantiate(body, transform.position - (i + 1) * new Vector3(0, 1, 0), Quaternion.identity) as GameObject;
            newbodynext.transform.parent = container.transform;
            snakeBody.Add(newbodynext);
        }
        now = down;
    }

    // Update is called once per frame
    void Update()
    {
        //移动
        if (now != up && now != down && Input.GetKey(KeyCode.W))
        {
            now = up;
        }
        if (now != up && now != down && Input.GetKey(KeyCode.S))
        {
            now = down;
        }
        if (now != left && now != right && Input.GetKey(KeyCode.A))
        {
            now = left;
        }
        if (now != left && now != right && Input.GetKey(KeyCode.D))
        {
            now = right;
        }

        timer += Time.deltaTime;

        if (timer > timerGap)
        {
            Vector3 tmpPosition = transform.position;
            List<Vector3> tmpList = new List<Vector3>();

            for (int i = 0; i < snakeBody.Count; ++i)
            {
                tmpList.Add(snakeBody[i].transform.position);
            }

            timer = 0;


            transform.position = 1 * now + transform.position;

            snakeBody[0].transform.position = tmpPosition;



            for (int i = 1; i < snakeBody.Count; ++i)
            {
                snakeBody[i].transform.position = tmpList[i - 1];
            }

        }

    }

    //吃到食物
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Food")
        {
            Destroy(col.gameObject);
            this.transform.name = "greedy";
            this.transform.tag = "Cube";
            foreach (Transform tran in GetComponentsInChildren<Transform>())
            {
                tran.gameObject.tag = "Cube";
            }
            this.transform.GetComponent<Greedy>().enabled = true;
            this.transform.GetComponent<Snake>().enabled = false;
        }
    }
}
