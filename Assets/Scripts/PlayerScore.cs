using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScore : MonoBehaviour {
    public Text scoreText;
    public int score = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}

    public void AddScore (int x)
    {
        score += x;
    }

    public int getScore()
    {
        return score;
    }

    public void setSCore(int x)
    {
        score = x;
    }
}
