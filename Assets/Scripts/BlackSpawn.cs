using UnityEngine;
using System.Collections;

public class BlackSpawn : MonoBehaviour {
    private float timer = 0f;
    private float spawnTimer = 0f;
    private int spawnCount = 0;
    public GameObject blackEnemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.5f)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= 0.66f && spawnCount < 4)
            {
                Instantiate(blackEnemy, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                spawnTimer = 0f;
                spawnCount++;
            }
            if (spawnCount == 4)
            {
                timer = 0f;
                spawnTimer = 0f;
                spawnCount = 0;
            }
        }
    }
}
