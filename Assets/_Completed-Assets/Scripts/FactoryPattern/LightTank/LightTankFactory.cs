using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTankFactory : TankFactory
{
    private const string ArmoredTankPrefabName = "ArmoredLightTank";
    private const string NonArmoredTankPrefabName = "NonArmoredLightTank";

    private NonArmoredLightTank nonArmoredLightTankTemp = new NonArmoredLightTank();
    private ArmoredLightTank armoredLightTankTemp = new ArmoredLightTank();

    // Start is called before the first frame update
    public override GameObject CreateNotArmoredTank()
    {
        GameObject nonArmoredLightTank = Resources.Load(NonArmoredTankPrefabName) as GameObject;
        if (nonArmoredLightTank != null)
        {
            nonArmoredLightTank.GetComponent<TankHealth>().m_StartingHealth = nonArmoredLightTankTemp.startingHealth;
            nonArmoredLightTank.GetComponent<TankMovement>().m_TurnSpeed = nonArmoredLightTankTemp.turnSpeed;
            nonArmoredLightTank.GetComponent<TankMovement>().m_Speed = nonArmoredLightTankTemp.movementSpeed;

            return nonArmoredLightTank;
        }
        else
        {
            throw new System.ArgumentException(NonArmoredTankPrefabName + "could not be found inside or loaded from Resources folder");
        }
    }

    public override GameObject CreateArmoredTank()
    {
        GameObject armoredLightTank = Resources.Load(ArmoredTankPrefabName) as GameObject;
        if (armoredLightTank != null) 
        {
            armoredLightTank.GetComponent<TankHealth>().m_StartingHealth = armoredLightTankTemp.startingHealth;
            armoredLightTank.GetComponent<TankMovement>().m_TurnSpeed = armoredLightTankTemp.turnSpeed;
            armoredLightTank.GetComponent<TankMovement>().m_Speed = armoredLightTankTemp.movementSpeed;

            return armoredLightTank;
        }
        else
        {
            throw new System.ArgumentException(NonArmoredTankPrefabName + "could not be found inside or loaded from Resources folder");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
