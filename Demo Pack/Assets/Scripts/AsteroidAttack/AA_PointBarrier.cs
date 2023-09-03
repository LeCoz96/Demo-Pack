using UnityEngine;

public class AA_PointBarrier : MonoBehaviour
{
    [SerializeField] private GameObject _score;

    private StarMaster m_starMaster;

    void Start()
    {
        m_starMaster = _score.GetComponent<StarMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
            m_starMaster.UpdateScore();
    }
}
