﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void LoadGameLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
