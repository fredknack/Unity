using UnityEngine;

public abstract class CrateBaseState
{
    public abstract void EnterState(CrateStateManager crate);

    public abstract void UpdateState(CrateStateManager crate);

    public abstract void OnCollisionEnter(CrateStateManager crate, Collision collision);
}
