using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{

    public float MaxSpeed = 10f;
    private Transform ThisTransform = null;

    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    void Update()
    {
        ThisTransform.position += ThisTransform.forward * MaxSpeed * Time.deltaTime;
    }
}