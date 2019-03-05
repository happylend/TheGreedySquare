using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    public string Scene;
    public bool quitButton = false;

    void Awake()
    {
        Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
        button.onClick.AddListener(onClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void onClick()
    {
        if (quitButton)
            Application.Quit();//退出
        else
            Application.LoadLevel(Scene);//场景跳转
    }
}
