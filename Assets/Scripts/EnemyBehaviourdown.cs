using UnityEngine;
using System.Collections;

public class EnemyBehaviourdown : MonoBehaviour {
    public static float speed;
    public float veloci;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MoveDown(speed);
	}
    public void MoveDown(float vel)
    {
        transform.Translate(Vector2.down * vel * Time.deltaTime);
        
    }
}
