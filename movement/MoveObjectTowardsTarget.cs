using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectTowardsTarget : MonoBehaviour
{
    // Vector3 targetForMovingObject = new Vector3(0,0,0);
    //
    // [SerializeField]
    // private float moveObjectTowardsTargetSpeed;
    // void LateUpdate() {
    //     MoveObjectAtConstantSpeedTowardsTarget();
    // }
    //
    // private void MoveObjectAtConstantSpeedTowardsTarget(){
    //     float distance = Vector3.Distance(targetForMovingObject, transform.position);
    //
    //     if(distance > 1.0f){
    //         Vector3 dir = targetForMovingObject - transform.position;
    //         dir.Normalize();
    //         transform.position += dir * moveObjectTowardsTargetSpeed * Time.deltaTime;
    //     }
    // }
    [SerializeField] private Transform targetTransform;

    private bool arrivedAtTarget = false;

    private void Update()
    {
        
        if (arrivedAtTarget) return;
        
        Vector3 moveDir = (targetTransform.position - transform.position).normalized;

        float moveSpeed = 10f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        if (Vector3.Distance(transform.position, targetTransform.position) < .5f)
        {
            arrivedAtTarget = true;
            Debug.Log("Arrived at Target!");
        }
    }

}
