using UnityEngine;

public class AA_PointBarrier : MonoBehaviour
{
    [SerializeField] private GameObject _starValue;
    [SerializeField] private SO_ScoreManager _scoreManager;
    [SerializeField] private int _buildNumber;

    private void Update()
    {
        Debug.Log(_scoreManager.GetAAEasyScore());
        Debug.Log(_scoreManager.GetAAMediumScore());
        Debug.Log(_scoreManager.GetAAHardScore());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _scoreManager.AddStar(_starValue);
            _scoreManager.IncreaseScore(_buildNumber);
        }
    }
}
