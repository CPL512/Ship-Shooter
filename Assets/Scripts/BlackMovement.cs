using UnityEngine;
using System.Collections;

public class BlackMovement : MonoBehaviour {
    private int speed = 12;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Camera.main.WorldToViewportPoint(this.transform.position).x < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
