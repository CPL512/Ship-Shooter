using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
    public GameObject spawnPosObj;
    private float shotTimer = 0.0f;
    public GameObject enemyBullet;
    protected float timing1 = 0.2f;
    protected float timing2 = 0.4f;
    protected float timing3 = 0.6f;
    protected float timeMax = 1.2f;

	// Use this for initialization
	protected virtual void Start () {
	
	}
	
	// Update is called once per frame
	protected void Update () {
        Debug.Log("update reached");
        shotTimer += Time.deltaTime;
        if(shotTimer == timing1 || shotTimer == timing2 || shotTimer == timing3)
        {
            Debug.Log("timer reached");
            Instantiate(enemyBullet, new Vector3(this.transform.position.x, this.transform.position.y - 2, this.transform.position.z), Quaternion.identity);
            Debug.Log("shot fired");
        }
        else if(shotTimer >= timeMax)
        {
            shotTimer = 0.0f;
        }
	}
}
