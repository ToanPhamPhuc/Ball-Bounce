using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D rb;

    public bool IsGameOver { get; private set; }

    [System.Obsolete]
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1f, 1f), 1f).normalized * speed; 
    }

    [System.Obsolete]
    private void Update()
    {
        Vector2 ballPos = transform.position;
        float screenHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
        float screenHalfHeight = Camera.main.orthographicSize;

        if (ballPos.x < -screenHalfWidth || ballPos.x > screenHalfWidth)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (ballPos.y > screenHalfHeight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -GetComponent<Rigidbody2D>().velocity.y);
        }

        if (ballPos.y < -screenHalfHeight)
        {
            IsGameOver = true;
        }
    }

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.CompareTag("Block"))
        //{
        //    Destroy(collision.gameObject);
        //    Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //    rb.velocity = rb.velocity.normalized * speed;
        //}

        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 bounce = new Vector2(
                (transform.position.x - collision.transform.position.x) * 2, 1).normalized;

            rb.velocity = bounce * speed; 
        }
    }
}
