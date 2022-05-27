using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateOpeningState : CrateBaseState
{
    private float openingCountdown = 3.0f;
    
    public override void EnterState(CrateStateManager crate)
    {
        
        
        Debug.Log("EnterState: Opening");
        
    }

    public override void UpdateState(CrateStateManager crate)
    {
        if(openingCountdown > 0)
        {
            openingCountdown -= Time.deltaTime;
        } else {
            crate.SwitchState(crate.OpenState);
        }
    }

    public override void OnCollisionEnter(CrateStateManager crate, Collision collision)
    {
        //throw new System.NotImplementedException();
    }
}
