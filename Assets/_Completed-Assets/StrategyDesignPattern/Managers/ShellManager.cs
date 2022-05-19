using System.Collections;
using System.Collections.Generic;
using Complete;
using UnityEngine;

public class ShellManager : MonoBehaviour
{
    [SerializeField] private BaseShell shell;
    
    //private FireShell fireShell = new FireShell();
    //private IceShell iceShell = new IceShel

    private bool isFire = true;
    
    //SHELL
    //RUN TIME DA DEĞİŞTİR
    private IShell runTimeShell;
    void Start()
    {
        //fireShell.UpdateStats(shell);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isFire)
            {
                runTimeShell =new FireShell();
                runTimeShell.UpdateStats(shell);
                runTimeShell.Effect();
                //iceShell.UpdateStats(shell);
                //iceShell.Effect();
                isFire = false;
            }
            else
            {
                runTimeShell =new IceShell();
                runTimeShell.UpdateStats(shell);
                runTimeShell.Effect();
                //fireShell.UpdateStats(shell);
                //fireShell.Effect();
                isFire = true;
            }
            
        }
    }
}
