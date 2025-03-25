using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float screenWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenWidth = Camera.main.orthographicSize * Camera.main.aspect;    
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x + move, -screenWidth + 1, screenWidth - 1),
            transform.position.y,
            transform.position.z
            );
    }
}
