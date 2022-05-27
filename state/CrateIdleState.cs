using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateIdleState : CrateBaseState
{
    public override void EnterState(CrateStateManager crate)
    {
        Debug.Log("EnterState: Idle");
        crate.SwitchState(crate.ActiveState);
    }

    public override void UpdateState(CrateStateManager crate)
    {
        //throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter(CrateStateManager crate, Collision collision)
    {
        //throw new System.NotImplementedException();
    }
}
