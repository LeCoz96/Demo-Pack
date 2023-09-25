using UnityEngine;

public class AA_PlayerCollisionDetection : MonoBehaviour
{
    [SerializeField] private GameObject _winLoseObject;
    [SerializeField] private SO_ScoreManager _scoreManager;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Asteroid")
        {
            _animator.SetTrigger("Explode");
        }
        if (collision.gameObject.transform.tag == "FinishLine")
        {
            _winLoseObject.SetActive(true);
            _winLoseObject.GetComponent<WinLoseMaster>().WinLoseDecision(0);
        }
    }

    private void GameOver()
    {
        _scoreManager.SetCurrentScore(0);
        _winLoseObject.SetActive(true);
        _winLoseObject.GetComponent<WinLoseMaster>().WinLoseDecision(1);
    }
}
