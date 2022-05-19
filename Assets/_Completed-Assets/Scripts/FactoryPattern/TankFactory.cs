using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TankFactory : MonoBehaviour
{
    // Start is called before the first frame update

    public abstract GameObject CreateNotArmoredTank();

    public abstract GameObject CreateArmoredTank();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
