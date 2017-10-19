using UnityEngine;
using System.Collections;

public class BlackHealth : EnemyHealth {
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        health = 5;
        scoreBonus = 250;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
