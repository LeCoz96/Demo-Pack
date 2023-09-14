using UnityEngine;
using TMPro;
using System.Collections;

public class CountdownMaster : MonoBehaviour
{
    [SerializeField] private int _countdownTime;
    [SerializeField] private string _timerFinishMessage;
    [SerializeField] private TextMeshProUGUI _countdownTimerText;
    [SerializeField] private SO_GameManager _gameManager;

    //private void Awake()
    //{
    //    StartCoroutine(Countdown());
    //}

    private void OnEnable()
    {
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        _gameManager.PauseGame();

        _countdownTime = 3;

        while (_countdownTime > 0)
        {
            _countdownTimerText.text = _countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1.0f);

            --_countdownTime;
        }

        _countdownTimerText.text = _timerFinishMessage;

        yield return new WaitForSecondsRealtime(1.0f);

        _gameManager.ResumeGame();

        gameObject.SetActive(false);
    }
}
