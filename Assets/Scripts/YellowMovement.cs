using UnityEngine;
using System.Collections;

public class YellowMovement : MonoBehaviour {
    private int speed = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(Camera.main.WorldToViewportPoint(this.transform.position).x > 1.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
