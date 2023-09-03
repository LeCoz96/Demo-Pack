using UnityEngine;

public class AA_PlayerMovement : MonoBehaviour
{
    [SerializeField] float _playerMovement;

    private Rigidbody2D _rigidbody;

    private float _horizontal;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_horizontal * _playerMovement, _rigidbody.velocity.y);
    }
}
