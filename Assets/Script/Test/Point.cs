using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public Vector3 P;
    List<Vector3> post = new List<Vector3>();
    //public GameObject cube;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Food")
        {
            P = this.transform.position;
            foreach (Transform child in transform)
            {
                post.Add(child.gameObject.transform.position);
                //Debug.Log(child.gameObject.transform.position);
            }
            print(post[0]);
            print(post[1]);
            print(post[2]);

            //GameObject newcube0 = Instantiate(cube, P, Quaternion.identity) as GameObject;
            for (int i = 0; i < 3; i++)
            {
                //GameObject newcube = Instantiate(cube, post[i], Quaternion.identity) as GameObject;
            }
        }
        //print(P);
        

    }
}
