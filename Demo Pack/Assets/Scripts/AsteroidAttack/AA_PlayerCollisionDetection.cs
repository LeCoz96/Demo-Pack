using UnityEngine;

public class AA_PlayerCollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverObject;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Asteroid")
            _animator.SetTrigger("Explode");
    }

    private void GameOver()
    {
        _gameOverObject.SetActive(true);
    }
}
