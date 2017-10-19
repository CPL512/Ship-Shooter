using UnityEngine;
using System.Collections;

public class SideShipMovement : ShipMovement {
    public GameObject forwardShip;
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
        if (Input.GetKey(KeyCode.LeftShift) && timer == 0f)
        {
            Instantiate(forwardShip, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            timer = 2f;
        }
    }
}
