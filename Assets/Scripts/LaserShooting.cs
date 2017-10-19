using UnityEngine;
using System.Collections;

public class LaserShooting : MonoBehaviour {
    public GameObject spawnPosObj;
    private float shotTimer = 0.0f;
    private float laserTimer = 0.0f;
    public GameObject laserWarmup;
    public GameObject laserFire;
    private bool fired = false;
    private bool warmedUp = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!fired)
        {
            shotTimer += Time.deltaTime;
        }
        if (shotTimer >= 2.0f && !fired)
        {
            laserTimer += Time.deltaTime;
            if (laserTimer <= 2.0f && !warmedUp)
            {
                Instantiate(laserWarmup, new Vector3(spawnPosObj.transform.position.x, spawnPosObj.transform.position.y, spawnPosObj.transform.position.z), Quaternion.identity);
                warmedUp = true;
            }
            else if (laserTimer > 2.0f)
            {
                Instantiate(laserFire, new Vector3(spawnPosObj.transform.position.x, spawnPosObj.transform.position.y, spawnPosObj.transform.position.z), Quaternion.identity);
                fired = true;
            }
        }

    }
}
