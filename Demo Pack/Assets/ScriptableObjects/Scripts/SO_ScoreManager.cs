using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Scriptable Objects/ScoreManager")]
public class SO_ScoreManager : ScriptableObject
{
    [SerializeField] private GameObject _star;

    private int _maxScore = 3;

    #region AsteroidAttack
    private int _aaEasyScore = 0;
    private int _aaMediumScore = 0;
    private int _aaHardScore = 0;
    public int GetAAEasyScore() { return  _aaEasyScore; }
    public int GetAAMediumScore() { return _aaMediumScore; }
    public int GetAAHardScore() { return _aaHardScore; }
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

    public void IncreaseScore(int BuildNumber)
    {
        switch (BuildNumber)
        {
            case 2:
                ++_aaEasyScore;
                CheckStarScore(_aaEasyScore);
                //if (_aaEasyScore > _maxScore)
                //    _aaEasyScore = _maxScore;
                //else
                //    ++_aaEasyScore;
                break;
            case 3:
                CheckStarScore(_aaMediumScore);
                break;
            case 4:
                CheckStarScore(_aaHardScore);
                break;
        }
    }

    private void CheckStarScore(int Score)
    {
        if (Score > _maxScore)
            Score = _maxScore;
    }

    public void AddStar(GameObject TargetObject)
    {
        Instantiate(_star, TargetObject.transform);
    }
}
