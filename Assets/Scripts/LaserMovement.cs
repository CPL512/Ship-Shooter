using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour {
    private int speed = 40;
    private float timer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer < .125f || timer > 7)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Camera.main.WorldToViewportPoint(this.transform.position).y < 0.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
