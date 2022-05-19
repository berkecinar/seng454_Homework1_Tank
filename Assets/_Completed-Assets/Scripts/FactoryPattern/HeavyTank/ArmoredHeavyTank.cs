using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoredHeavyTank : HeavyTank
{
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 8f;
        turnSpeed = 130f;
        startingHealth = 150f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
