using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health = 3;
    private TextMeshPro textMesh;
    private void Start()
    {
        GameObject textObj = new GameObject("BrickText");
        textObj.transform.SetParent(transform);
        textObj.transform.localPosition = Vector3.zero; 

        textMesh = textObj.AddComponent<TextMeshPro>();
        textMesh.alignment = TextAlignmentOptions.Center;
        textMesh.color = Color.black;
        textMesh.fontSize = 5;

        UpdateHealthText();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            health--;
            if(health <= 0 )
            {
                Destroy(gameObject);
            }
            else
            {
                UpdateHealthText();
            }
            
        }
    }

    private void UpdateHealthText()
    {
        if(textMesh != null)
        {
            textMesh.text = health.ToString();  
        }
    }
}
