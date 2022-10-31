using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float _speed = 20f;
    Rigidbody _rigidBody;
    Vector3 _velocity;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.velocity = Vector3.down * _speed;
    }

    void FixedUpdate()
    {
        _rigidBody.velocity = _rigidBody.velocity.normalized * _speed;
        _velocity = _rigidBody.velocity;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        _rigidBody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
    }
}
