using UnityEngine;
using System.Collections;
// Attach this to a gameObject to make it spin at a given speed
public class SpinObject : MonoBehaviour
{
    public int speed = 50;

    void Update()
    {
        transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
}