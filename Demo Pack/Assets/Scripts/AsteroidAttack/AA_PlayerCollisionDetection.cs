using UnityEngine;

public class AA_PlayerCollisionDetection : MonoBehaviour
{
    private Animator m_animator;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Asteroid")
            m_animator.SetTrigger("Explode");
    }
}
