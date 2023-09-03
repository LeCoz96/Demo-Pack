using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundaries : MonoBehaviour
{
    private Vector2 _screenBoundaries;

    private float _gameObjectWidth;
    private float _gameObjectHeight;

    void Start()
    {
        _screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _gameObjectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / -2;
        _gameObjectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / -2;
    }

    void LateUpdate()
    {
        Vector2 viewPosition = transform.position;

        viewPosition.x = Mathf.Clamp(viewPosition.x, _screenBoundaries.x * -1 - _gameObjectWidth, _screenBoundaries.x + _gameObjectWidth);
        viewPosition.y = Mathf.Clamp(viewPosition.y, _screenBoundaries.y * -1 - _gameObjectHeight, _screenBoundaries.y + _gameObjectHeight);
        
        transform.position = viewPosition;
    }
}
