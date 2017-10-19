using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
    protected int health;
    protected int scoreBonus;
    protected PlayerScore playerScript;

	// Use this for initialization
	protected virtual void Start () {
        playerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerScore>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loseHealth()
    {
        health--;
        if (health == 0)
        {
            playerScript.AddScore(scoreBonus);
            Destroy(this.gameObject);
        }
    }
}
