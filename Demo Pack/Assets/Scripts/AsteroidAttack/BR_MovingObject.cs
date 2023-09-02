using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BR_MovingObject : MonoBehaviour
{
    [SerializeField] float _movementSpeed;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(0.0f, -_movementSpeed * Time.fixedDeltaTime);
    }
}
