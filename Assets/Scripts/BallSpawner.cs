using System;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (ball != null) {
            SpawnBall();
        }
    }

    private void SpawnBall()
    {
       GameObject obj =  Instantiate(ball);
        obj.transform.position = new Vector3(0, -2.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
