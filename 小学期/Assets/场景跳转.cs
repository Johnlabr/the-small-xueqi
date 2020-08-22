using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 场景跳转 : MonoBehaviour {
    //public Button jump;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Onclick()
    {
        SceneManager.LoadScene("工作区");
    }
}
