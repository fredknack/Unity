using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apply this script to a capsule with a rigidbody (no gravity) and rotation constraint checkboxes selected.
//Make a camera a child of the capsule. Make sure it is tagged as the Main Camera.

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed; //6
    public float jumpForce; //7

    [Header ("Camera")]
    public float lookSensitivity; //5
    public  float MaxLookX; //80
    public float minLookX; //-80
    private float rotX;
    private Camera cam;
    private Rigidbody rig;
    
    void Awake()
    {
        cam = Camera.main;
        rig = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        Move();
        if(Input.GetButtonDown("Jump")){
            TryJump();
        }
        CamLook();
    }

    void Move() {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rig.velocity.y;
        rig.velocity = dir;
    }

    void CamLook() {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
        rotX = Mathf.Clamp(rotX, minLookX, MaxLookX);
        cam.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void TryJump() {
        print("Jump");
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, 1.5f)){
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
