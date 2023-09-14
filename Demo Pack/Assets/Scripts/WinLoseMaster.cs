using Unity.VisualScripting;
using UnityEngine;

public class WinLoseMaster : MonoBehaviour
{
    [SerializeField] private SO_GameManager _gameManager;

    private void OnEnable()
    {
        _gameManager.PauseGame();
    }
}
