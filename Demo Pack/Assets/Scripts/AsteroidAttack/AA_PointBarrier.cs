using UnityEngine;

public class AA_PointBarrier : MonoBehaviour
{
    [SerializeField] private GameObject _starValue;
    [SerializeField] private SO_ScoreManager _scoreManager;
    [SerializeField] private int _buildNumber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _scoreManager.IncreaseScore(_starValue);
        }
    }
}
