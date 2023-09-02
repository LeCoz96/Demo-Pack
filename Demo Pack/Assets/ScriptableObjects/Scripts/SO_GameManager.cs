using UnityEngine;

[CreateAssetMenu(fileName ="ScriptableObject", menuName = "Scriptable Objects/GameManager")]
public class SO_GameManager : ScriptableObject
{
    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
    }
}
