using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    [SerializeField] int m_sceneIndexNumber;
    
    public void SceneSelection()
    {
        SceneManager.LoadScene(m_sceneIndexNumber);
    }
}
