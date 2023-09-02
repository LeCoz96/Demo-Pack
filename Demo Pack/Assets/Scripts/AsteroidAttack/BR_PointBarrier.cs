using UnityEngine;

public class BR_PointBarrier : MonoBehaviour
{
    [SerializeField] private GameObject _score;
    [SerializeField] private int _value;

    private ScoreMaster m_scoreManager;

    void Start()
    {
        m_scoreManager = _score.GetComponent<ScoreMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
            m_scoreManager.UpdateScore(_value);
    }
}
