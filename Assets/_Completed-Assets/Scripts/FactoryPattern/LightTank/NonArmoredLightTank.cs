using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonArmoredLightTank : LightTank
{
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 15f;
        turnSpeed = 225f;
        startingHealth = 80f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
