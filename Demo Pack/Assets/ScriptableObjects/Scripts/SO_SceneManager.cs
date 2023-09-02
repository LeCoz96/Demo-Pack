using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Scriptable Objects/SceneManager")]
public class SO_SceneManager : ScriptableObject
{
    public void LoadNextScene(int SceneIndexNumber)
    {
        SceneManager.LoadScene(SceneIndexNumber);
    }

    public int GetSceneIndex() { return SceneManager.GetActiveScene().buildIndex; }
}
