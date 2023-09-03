using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_AsteroidRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    void Update()
    {
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, _rotationSpeed));
    }
}
