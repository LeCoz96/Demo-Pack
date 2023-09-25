using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinLoseMaster : MonoBehaviour
{
    [SerializeField] private SO_GameManager _gameManager;
    [SerializeField] private SO_ScoreManager _scoreManager;

    [SerializeField] private string _winText;
    [SerializeField] private string _loseText;

    [SerializeField] private TextMeshProUGUI _winLoseText;

    private void Awake()
    {
        _winLoseText.text = "";
    }

    public void WinLoseDecision(int WinLose)
    {
        _gameManager.PauseGame();


        switch (WinLose)
        {
            case 0:
                _winLoseText.text = _winText;
                _scoreManager.SetIsAlive(true);
                break;
            case 1:
                _winLoseText.text = _loseText;
                _scoreManager.SetIsAlive(false);
                break;
            default:
                break;
        }

        _scoreManager.SetScore(SceneManager.GetActiveScene().buildIndex);
    }
}
