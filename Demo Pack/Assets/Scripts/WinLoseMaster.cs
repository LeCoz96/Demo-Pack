using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseMaster : MonoBehaviour
{
    [SerializeField] private SO_GameManager _gameManager;
    [SerializeField] private SO_ScoreManager _scoreManager;


    private void OnEnable()
    {
        _gameManager.PauseGame();
        _scoreManager.SetScore(SceneManager.GetActiveScene().buildIndex);
    }
}
