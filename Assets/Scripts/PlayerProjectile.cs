using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {
    public GameObject spawnPosObj;
    public GameObject bullet;
    private float timer;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.75f)
        {
            Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
            timer = 0;
        }

    }

   // protected virtual void spawnBullet() { }

}
