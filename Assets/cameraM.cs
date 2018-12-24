using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CnControls;

public class cameraM : MonoBehaviour {

    private float hori = 0;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        //hori = Input.GetAxis("Horizontal");
        hori = CnInputManager.GetAxis("Horizontal");
        this.GetComponent<Transform>().Rotate(0, hori * 0.1f, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("seni");
        }
	}
}
