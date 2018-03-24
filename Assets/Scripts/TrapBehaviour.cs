using UnityEngine;
using System.Collections;

public class TrapBehaviour : MonoBehaviour {
    public GameObject trap;
    public float curredTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        curredTime -= Time.deltaTime;
        if (curredTime < 0)
        {
            curredTime = 0;
        }
        if(curredTime == 0)
        {
            Instantiate(trap, transform.position, trap.transform.rotation);
            curredTime = 4;
        }
	}
}
