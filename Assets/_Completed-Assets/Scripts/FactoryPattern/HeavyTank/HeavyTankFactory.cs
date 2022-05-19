using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyTankFactory : TankFactory
{
    private const string ArmoredTankPrefabName = "ArmoredHeavyTank";
    private const string NonArmoredTankPrefabName = "NonArmoredHeavyTank";

    private NonArmoredHeavyTank nonArmoredHeavyTankTemp = new NonArmoredHeavyTank();
    private ArmoredHeavyTank armoredHeavyTankTemp = new ArmoredHeavyTank();

    // Start is called before the first frame update
    public override GameObject CreateNotArmoredTank()
    {
        GameObject nonArmoredHeavyTank = Resources.Load(NonArmoredTankPrefabName) as GameObject;
        if (nonArmoredHeavyTank != null)
        {
            nonArmoredHeavyTank.GetComponent<TankHealth>().m_StartingHealth = nonArmoredHeavyTankTemp.startingHealth;
            nonArmoredHeavyTank.GetComponent<TankMovement>().m_TurnSpeed = nonArmoredHeavyTankTemp.turnSpeed;
            nonArmoredHeavyTank.GetComponent<TankMovement>().m_Speed = nonArmoredHeavyTankTemp.movementSpeed;

            return nonArmoredHeavyTank;
        }
        else
        {
            throw new System.ArgumentException(NonArmoredTankPrefabName + "could not be found inside or loaded from Resources folder");
        }
    }

    public override GameObject CreateArmoredTank()
    {
        GameObject armoredHeavyTank = Resources.Load(ArmoredTankPrefabName) as GameObject;
        if (armoredHeavyTank != null) 
        {
            armoredHeavyTank.GetComponent<TankHealth>().m_StartingHealth = armoredHeavyTankTemp.startingHealth;
            armoredHeavyTank.GetComponent<TankMovement>().m_TurnSpeed = armoredHeavyTankTemp.turnSpeed;
            armoredHeavyTank.GetComponent<TankMovement>().m_Speed = armoredHeavyTankTemp.movementSpeed;

            return armoredHeavyTank;
        }
        else
        {
            throw new System.ArgumentException(NonArmoredTankPrefabName + "could not be found inside or loaded from Resources folder");
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
