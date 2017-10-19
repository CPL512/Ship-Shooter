using UnityEngine;
using System.Collections;

public class LaserWarmupScript : MonoBehaviour {
    private float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= 1.5f)
        {
            Destroy(this.gameObject);
        }
	}
}
