using UnityEngine;
using System.Collections;

public class LaserSpawn : MonoBehaviour {
    private float timer = 0f;
    private float spawnTimer = 0f;
    private int spawnCount = 0;
    public GameObject laserEnemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            Instantiate(laserEnemy, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            timer = 0;
        }
    }
}
