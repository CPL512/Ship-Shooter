using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerLives : MonoBehaviour {
    public Text livesText;
    private int lives = 5;
    private bool alive = true;
    private float timer = 0f;
    public PlayerScore scoreKeeper;
    public static int lastScore;

	// Use this for initialization
	void Start () {
        scoreKeeper = this.gameObject.GetComponent<PlayerScore>();
	}
	
	// Update is called once per frame
	void Update () {
        livesText.text = "Lives: " + lives;
        if(alive == false)
        {
            if(timer >= 1.0f)
            {
                alive = true;
                timer = 0f;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
	}

    public void LoseLives(int livesLost)
    {
        if(lives >= 0 && livesLost < lives)
        {
            if (alive == true)
            {
                lives -= livesLost;
                alive = false;
            }
            
        }
        else
        {
            lastScore = scoreKeeper.getScore();
            SceneManager.LoadScene("GameOver");
        }
    }

    public void setLives(int x)
    {
        lives = x;
    }
}
