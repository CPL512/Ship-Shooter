using UnityEngine;
using System.Collections;

public class YellowHealth : EnemyHealth {
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        health = 1;
        scoreBonus = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
