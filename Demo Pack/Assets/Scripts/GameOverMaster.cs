using UnityEngine;

public class GameOverMaster : MonoBehaviour
{
    [SerializeField] private SO_GameManager _gameManager;

    private void OnEnable()
    {
        _gameManager.PauseGame();
    }
}
