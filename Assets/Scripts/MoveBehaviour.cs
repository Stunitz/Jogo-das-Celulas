using UnityEngine;
using System.Collections;

public class MoveBehaviour : MonoBehaviour {
    private float direction1;
    private float direction2;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        // movimentaçao do personagem



        // capturar a direção de deslocamento:
        direction1 = Input.GetAxis("Horizontal");
        direction2 = Input.GetAxis("Vertical");

        // movimentar o player:
        transform.Translate(new Vector2(direction1, direction2) * speed * Time.deltaTime);

    }
}
