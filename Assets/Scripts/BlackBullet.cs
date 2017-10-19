using UnityEngine;
using System.Collections;

public class BlackBullet : MonoBehaviour {
    private PlayerLives playerScript;

    // Use this for initialization
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerLives>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 10 * Time.deltaTime);
        if (Camera.main.WorldToViewportPoint(this.transform.position).y < 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerScript.LoseLives(2);
            Destroy(this.gameObject);
        }
    }
}
