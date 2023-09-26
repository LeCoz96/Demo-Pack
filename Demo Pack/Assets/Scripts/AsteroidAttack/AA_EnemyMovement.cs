using System.Collections;
using UnityEngine;

public class AA_EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    private float _movementSpeed;

    [SerializeField] private GameObject _leftTarget;
    [SerializeField] private GameObject _rightTarget;

    [SerializeField] private float _pauseTime;

    private Rigidbody2D _rigidbody;

    private bool _moveLeft = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _movementSpeed = Random.Range(_minSpeed, _maxSpeed);
    }

    void FixedUpdate()
    {
        if (_moveLeft)
        {
            _rigidbody.velocity = new Vector2(-_movementSpeed * Time.deltaTime, 0.0f);
        }
        else
        {
            //_rigidbody.MovePosition(Vector2.Lerp(transform.position, _rightTarget.gameObject.transform.position, _movementSpeed * Time.deltaTime));
            _rigidbody.velocity = new Vector2(_movementSpeed * Time.deltaTime, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Barrier")
        {
            StartCoroutine(Pause(_pauseTime));
        }
    }

    private void FlipDirection()
    {
        _moveLeft = !_moveLeft;
    }

    private IEnumerator Pause(float Delay)
    {
        yield return new WaitForSeconds(Delay);

        FlipDirection();
    }
}
