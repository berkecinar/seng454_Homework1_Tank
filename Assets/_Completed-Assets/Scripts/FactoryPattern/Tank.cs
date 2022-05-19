using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{

    //public GameObject tankPrefab;

    public float movementSpeed = 0f;
    public float turnSpeed = 0f;
    public float startingHealth = 0f;
    
    public enum TankType
    {
        LightTank,
        HeavyTank
    }

    public abstract TankType GetTankType();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
