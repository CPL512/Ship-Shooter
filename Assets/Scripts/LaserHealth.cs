using UnityEngine;
using System.Collections;

public class LaserHealth : EnemyHealth {
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        health = 3;
        scoreBonus = 500;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
