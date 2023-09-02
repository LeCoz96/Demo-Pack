using UnityEngine;
using TMPro;


public class ScoreMaster : MonoBehaviour
{
    [SerializeField] private SO_SceneManager _sceneManager;

    private TextMeshProUGUI _scoreText;

    private int _scoreValue;

    private int _br_e_scoreValue = 0;
    public int BR_E_GetScore() { return _br_e_scoreValue; }

    void Start()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();

        _scoreText.text = _br_e_scoreValue.ToString();
    }


    public void UpdateScore(int score)
    {
        _scoreValue += score;

        switch (_sceneManager.GetSceneIndex())
        {
            case 2:
                _br_e_scoreValue += score;
                break;
            default:
                break;
        }

        if (_scoreText != null)
            _scoreText.text = _scoreValue.ToString();
    }
}
