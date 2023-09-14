using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Scriptable Objects/ScoreManager")]
public class SO_ScoreManager : ScriptableObject
{
    [SerializeField] private GameObject _star;

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
                break;
            case 3:
                ++_aaMediumScore;
                break;
            case 4:
                ++_aaHardScore;
                break;
        }
    }

    public void AddStar(GameObject TargetObject)
    {
        Instantiate(_star, TargetObject.transform);
    }
}
