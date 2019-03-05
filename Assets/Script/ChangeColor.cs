using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
            float red = Random.Range(0.0f, 1.0f);
            float green = Random.Range(0.0f, 1.0f);
            float blue = Random.Range(0.0f, 1.0f);

            Renderer render = this.GetComponent<Renderer>();
            render.material.color = new Color(red, green, blue);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
