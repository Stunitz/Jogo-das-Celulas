using UnityEngine;
using System.Collections;

public class ShotBehaviour : MonoBehaviour {
    public Camera cam;
    private Vector3 mousePos;
    static public Vector3 miraBala;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.localPosition.z;

        miraBala = (mousePos-transform.position);
        transform.up = miraBala;
	}
}
