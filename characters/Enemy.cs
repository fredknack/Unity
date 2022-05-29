using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    private enum State
    {
        Idle,
        Attack,
        Patrol,
        Dead
    }

    private State state;

    private void Start()
    {
        state = State.Idle;
    }

    private void Update()
    {
        switch (state)
        {
            case State.Idle:
                break;
            case State.Attack:
                break;
        }
    }
    
    
    public void Damage()
    {
        print("Enemy Damage");
    }
}
