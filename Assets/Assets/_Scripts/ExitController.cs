﻿using UnityEngine;
using System.Collections;

public class ExitController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnExitButton()
    {
        Application.Quit();
    }
}
