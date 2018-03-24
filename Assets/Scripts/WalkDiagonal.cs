using UnityEngine;
using System.Collections;

public class WalkDiagonal : MonoBehaviour
{
    public int speed;
    // Use this for initialization
    void Start()
    {
        speed = 5;

    }
    
    void FixedUpdate()
    {
        walkDiagonal();
        if (transform.position.y < -45)
        {
            Destroy(gameObject);
        }
    }
    void walkDiagonal()
    {
        if (true) 
        { 
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}