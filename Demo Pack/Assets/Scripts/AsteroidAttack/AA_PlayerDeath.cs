using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_PlayerDeath : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayerDeath()
    {
        _animator.SetTrigger("Explode");
    }
}
