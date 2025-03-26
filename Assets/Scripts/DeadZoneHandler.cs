using Unity.VisualScripting;
using UnityEngine;

public class DeadZoneHandler : MonoBehaviour
{
    GameController m_gc;
    private void Start()
    {
        m_gc = gameObject.AddComponent<GameController>();   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")){
            Destroy(collision.gameObject);
            m_gc.IsGameOver = true;
        }
    }
    
    
}
