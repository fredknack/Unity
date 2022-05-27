using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateActiveState : CrateBaseState
{
    public override void EnterState(CrateStateManager crate)
    {
        Debug.Log("EnterState: Active");
    }

    public override void UpdateState(CrateStateManager crate)
    {
        //throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter(CrateStateManager crate, Collision collision)
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Player"))
        {
            crate.SwitchState(crate.OpeningState);
        }
    }
}
