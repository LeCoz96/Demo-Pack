using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAllocation : MonoBehaviour
{
    [SerializeField] private GameObject _star;
    [SerializeField] private SO_ScoreManager _scoreManager;
    [SerializeField] private int _buildNumber;

    private void Awake()
    {
        for (int i = 1; i < _scoreManager.GetScore(_buildNumber); i++)
            Instantiate(_star, transform);
    }
}
