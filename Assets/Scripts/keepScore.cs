using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class keepScore : MonoBehaviour {
    public Text scoreText;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + PlayerLives.lastScore;
    }
}
