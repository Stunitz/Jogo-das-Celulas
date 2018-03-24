using UnityEngine;
using System.Collections;

public class EnemyBehaviourup : MonoBehaviour {
    public static float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MoveUp(speed);
	}
    public void MoveUp(float vel)
    {
        transform.Translate(Vector2.up * vel * Time.deltaTime);
    }
}
