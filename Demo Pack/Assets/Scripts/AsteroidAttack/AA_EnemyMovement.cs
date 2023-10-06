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

    private float _parentYAxisSpeed;

    private bool _moveLeft = false;
    private bool _atBarrier = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _movementSpeed = Random.Range(_minSpeed, _maxSpeed);
    }

    void Update()
    {
        _parentYAxisSpeed = transform.GetComponentInParent<Transform>().position.y;
    }

    void FixedUpdate()
    {
        // Cant have kinematic and physics


        if (_atBarrier)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            if (_moveLeft)
            {
                _rigidbody.velocity = new Vector2(-_movementSpeed, _rigidbody.velocity.y) * Time.deltaTime;
            }
            else
            {
                _rigidbody.velocity = new Vector2(_movementSpeed, _rigidbody.velocity.y) * Time.deltaTime;
            }
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

        _atBarrier = false;
    }

    private IEnumerator Pause(float Delay)
    {
        _atBarrier = true;

        yield return new WaitForSeconds(Delay);

        FlipDirection();
    }
}
