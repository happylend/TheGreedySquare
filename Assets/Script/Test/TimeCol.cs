using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCol : MonoBehaviour {
    int flag = 1;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if(flag==1)
        {
            Time.timeScale = 1;
            flag = 0;
           GameObject.Find("Time_text").GetComponent<Text>().text = "暂停";
        }
        else if(flag==0)
        {
            Time.timeScale = 0;
            flag = 1;
            GameObject.Find("Time_text").GetComponent<Text>().text = "开始";
        }
    }
}
