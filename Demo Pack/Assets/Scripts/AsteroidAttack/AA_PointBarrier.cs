using UnityEngine;

public class AA_PointBarrier : MonoBehaviour
{
    [SerializeField] private GameObject _score;
    [SerializeField] private SO_ScoreManager _scoreManager;
    [SerializeField] private int _buildNumber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _scoreManager.AddStar(_score);
            _scoreManager.IncreaseScore(_buildNumber);
        }
    }
}
