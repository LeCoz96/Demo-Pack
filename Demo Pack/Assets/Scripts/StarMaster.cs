using TMPro;
using UnityEngine;

public class StarMaster : MonoBehaviour
{
    [SerializeField] private SO_SceneManager _sceneManager;
    [SerializeField] private GameObject _star;

    private int _aa_e_scoreValue = 0;
    public int BR_E_GetScore() { return _aa_e_scoreValue; }

    public void UpdateScore()
    {
        Instantiate(_star, transform);

        switch (_sceneManager.GetSceneIndex())
        {
            case 2:
                ++_aa_e_scoreValue;
                break;
            default:
                break;
        }
    }
}
