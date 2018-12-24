using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenM : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SceneSeni()
    {
        SceneManager.LoadScene("seni");
    }

    public void SceneMain()
    {
        SceneManager.LoadScene("main");
    }
}
