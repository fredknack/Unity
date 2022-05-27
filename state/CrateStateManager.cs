using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateStateManager : MonoBehaviour
{
    private CrateBaseState currentState;
    public CrateIdleState IdleState = new CrateIdleState();
    public CrateActiveState ActiveState = new CrateActiveState();
    public CrateOpeningState OpeningState = new CrateOpeningState();
    public CrateOpenState OpenState = new CrateOpenState();
    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(CrateBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }
    
}
