using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Scriptable Objects/ScoreManager")]
public class SO_ScoreManager : ScriptableObject
{
    [SerializeField] private GameObject _star;

    private int _maxScore = 3;
    private int _currentScore = 0;
    public int GetCurrentScore() { return _currentScore; }
    public void SetCurrentScore(int Value) { _currentScore = Value; }

    private bool _isAlive = false;
    public void SetIsAlive(bool verdict) { _isAlive = verdict; }

    #region AsteroidAttack
    private int _aaEasyScore = 0;
    private int _aaMediumScore = 0;
    private int _aaHardScore = 0;
    #endregion

    public int GetScore(int BuildNumber)
    {
        switch (BuildNumber)
        {
            case 2:
                return _aaEasyScore;
            case 3:
                return _aaMediumScore;
            case 4:
                return _aaHardScore;
            default:
                return 0;
        }
    }

    public void SetScore(int BuildNumber)
    {
        switch (BuildNumber)
        {
            case 2:
                CheckStarScore(ref _aaEasyScore);
                break;
            default:
                break;
        }
    }

    public void IncreaseScore(GameObject TargetObject)
    {
        ++_currentScore;
        AddStar(TargetObject);
    }

    private void CheckStarScore(ref int Score)
    {
        if (_isAlive)
        {
            if (Score >= _maxScore)
            {
                Score = _maxScore;
            }
            else
            {
                if (Score > _currentScore)
                {
                    return;
                }
                else
                {
                    Score = _currentScore;
                }
            }
        }
    }

    private void AddStar(GameObject TargetObject)
    {
        Instantiate(_star, TargetObject.transform);
    }
}
