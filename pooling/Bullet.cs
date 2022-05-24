using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody Rigidbody;
    public delegate void OnDisableCallback(Bullet Instance);
    public OnDisableCallback Disable;

    private ScoreManager scoreManager;

    void Awake() {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Start() {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") {
            scoreManager.score += 10;
            Disable?.Invoke(this);
        } else if (other.tag == "Spawner") {
        } else if (other.tag == "Bullet") {
        } else {
            Disable?.Invoke(this);
        }
    }

    public void Shoot(Vector3 Position, Vector3 Direction, float Speed)
    {
        Rigidbody.velocity = Vector3.zero;
        transform.position = Position;
        transform.forward = Direction;

        Rigidbody.AddForce(Direction * Speed, ForceMode.VelocityChange);
    }
}
