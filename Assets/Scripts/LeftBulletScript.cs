using UnityEngine;
using System.Collections;

public class LeftBulletScript : MonoBehaviour
{
    private PlayerScore playerScript;

    // Use this for initialization
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 15 * Time.deltaTime);
        if (Camera.main.WorldToViewportPoint(this.transform.position).x < 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowEnemy"))
        {
            Destroy(other.gameObject);
            playerScript.AddScore(100);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("BlackEnemy"))
        {
            Destroy(other.gameObject);
            playerScript.AddScore(250);
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("LaserEnemy"))
        {
            Destroy(other.gameObject);
            playerScript.AddScore(500);
            Destroy(this.gameObject);
        }
    }
}

