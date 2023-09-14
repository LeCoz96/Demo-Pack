using UnityEngine;

public class PauseMaster : MonoBehaviour
{
    [SerializeReference] private GameObject _pauseScreen;
    [SerializeReference] private GameObject _pauseButton;
    [SerializeReference] private GameObject _countdown;
    [SerializeReference] private SO_GameManager _gameManager;
    
    public void GamePause()
    {
        _gameManager.PauseGame();
        _pauseButton.SetActive(false);
        _pauseScreen.SetActive(true);
    }

    public void GameResume()
    {
        _countdown.SetActive(true);
        _pauseButton.SetActive(true);
        _pauseScreen.SetActive(false);
    }
}
