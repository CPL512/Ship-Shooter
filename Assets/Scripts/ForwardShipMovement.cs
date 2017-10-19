using UnityEngine;
using System.Collections;

public class ForwardShipMovement : ShipMovement {
    public GameObject sideShip;
    private float timer = 0f;

	// Use this for initialization
	protected override void Start () {
	
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightShift) && timer == 0f)
        {
            Instantiate(sideShip, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            timer = 2f;
        }
	}
}
