using UnityEngine;
using System.Collections;

public class YellowSpawn : MonoBehaviour {
    private float timer = 0f;
    private float spawnTimer = 0f;
    private int spawnCount = 0;
    public GameObject yellowEnemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= 1.2f)
        {
            spawnTimer += Time.deltaTime;
            if(spawnTimer >= 0.75f && spawnCount < 5)
            {
                Instantiate(yellowEnemy, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                spawnTimer = 0f;
                spawnCount++;
            }
            if(spawnCount == 5)
            {
                timer = 0f;
                spawnTimer = 0f;
                spawnCount = 0;
            }
        }
	}
}
