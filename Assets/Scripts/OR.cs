using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OR : LogicGateBase
{
    
    public override bool UseGate(){

        if (connectionPins[0].IsOn || connectionPins[1].IsOn) 
        {
            Debug.Log("true");
            return true;
            
        }
        else return false;
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
