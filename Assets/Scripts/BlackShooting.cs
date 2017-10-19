using UnityEngine;
using System.Collections;

public class BlackShooting : MonoBehaviour {
    public GameObject spawnPosObj;
    //private float shotTimer = 0.0f;
    private float bulletTimer = 0.0f;
    public GameObject enemyBullet;
    //private int bulletCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*shotTimer += Time.deltaTime;
        if (shotTimer >= 0.8f)
        {*/
            bulletTimer += Time.deltaTime;
            if (bulletTimer >= 0.4f /*&& bulletCount < 5*/)
            {
                Instantiate(enemyBullet, new Vector3(spawnPosObj.transform.position.x, spawnPosObj.transform.position.y - 0.25f, spawnPosObj.transform.position.z), Quaternion.identity);
                bulletTimer = 0;
                //bulletCount++;
            }
            /*if (bulletCount == 5)
            {
                shotTimer = 0f;
                bulletTimer = 0f;
                bulletCount = 0;
            }
        }*/

    }
}
