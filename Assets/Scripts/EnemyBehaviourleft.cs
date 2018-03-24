using UnityEngine;
using System.Collections;

public class EnemyBehaviourleft : MonoBehaviour {
    public static float speed;
	// Use this for initialization
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void MoveLeft(float vel)
    {
        transform.Translate(Vector2.left * vel * Time.deltaTime);
    }
    void FixedUpdate()
    {
        // chamando o método responsavel por mover a bullet:
        MoveLeft(speed);
    }

}
