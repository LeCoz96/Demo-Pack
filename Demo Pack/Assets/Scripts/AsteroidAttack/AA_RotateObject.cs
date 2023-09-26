using UnityEngine;

public class AA_RotateObject : MonoBehaviour
{
    [SerializeField] private float _rotationSpeedMin;
    [SerializeField] private float _rotationSpeedMax;

    private float _rotationSpeed;

    void Start()
    {
        _rotationSpeed = Random.Range(_rotationSpeedMin, _rotationSpeedMax);
    }

    void Update()
    {
        transform.Rotate(0.0f, 0.0f, _rotationSpeed * Time.deltaTime, Space.Self);
    }
}
