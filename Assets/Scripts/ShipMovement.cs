using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {
    protected int speed = 10;

	// Use this for initialization
	protected virtual void Start () {
        
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
