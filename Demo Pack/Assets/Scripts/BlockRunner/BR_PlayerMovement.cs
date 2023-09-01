using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BR_PlayerMovement : MonoBehaviour
{
    [SerializeField] float m_playerMovement;

    private Rigidbody2D m_rigidbody;

    private float m_horizontal;

    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        m_rigidbody.velocity = new Vector2(m_horizontal * m_playerMovement, m_rigidbody.velocity.y);
    }
}
