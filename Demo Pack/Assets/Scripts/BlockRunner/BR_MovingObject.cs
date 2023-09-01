using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BR_MovingObject : MonoBehaviour
{
    [SerializeField] float m_movementSpeed;

    private Rigidbody2D m_rigidbody;

    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        m_rigidbody.velocity = new Vector2(0.0f, -m_movementSpeed * Time.fixedDeltaTime);
    }
}
