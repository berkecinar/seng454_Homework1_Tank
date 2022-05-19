using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoredLightTank : LightTank
{
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 12f;
        turnSpeed = 180f;
        startingHealth = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
