using UnityEngine;

public class AA_PlayerCollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject _loseObject;
    [SerializeField] private GameObject _winObject;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Asteroid")
            _animator.SetTrigger("Explode");
        if (collision.gameObject.transform.tag == "FinishLine")
            _winObject.SetActive(true);
    }

    private void GameOver()
    {
        _loseObject.SetActive(true);
    }
}
