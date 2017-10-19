using UnityEngine;
using System.Collections;

public class LaserFire : MonoBehaviour {
    private PlayerLives playerScript;
    private float timer = 0;

	// Use this for initialization
	void Start () {
        playerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerLives>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= 3.0f){
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerScript.LoseLives(2);
        }
    }
}
