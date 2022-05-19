using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonArmoredHeavyTank : HeavyTank
{
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 10f;
        turnSpeed = 150f;
        startingHealth = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
