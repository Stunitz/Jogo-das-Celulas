using UnityEngine;
using System.Collections;

public class MoveCamBehaviour : MonoBehaviour {
    public Transform cam;
    public bool setaDireita;
    public bool setaEsquerda;
    private Vector3 showRight;
    private Vector3 showLeft;
    public float speed = 1;
    public float step;
    private float fireRate;
    private bool clickDireita = false;
	// Use this for initialization
	void Start () {
        showLeft.y = showRight.y = 0;
        showLeft.z = showRight.z = -10;
        showRight.x = -8.88f;
        showLeft.x = 8.88f;
        Time.timeScale = 0.001f;
	}
	
	// Update is called once per frame
	void Update () {
        step = speed * Time.deltaTime;

	}
    void OnMouseDown()
    {
        if(setaDireita)
        {
            while (cam.position.x < 8.88f)
            {
                cam.position = Vector3.MoveTowards(cam.position, showLeft, step);
            }

        }
        if(setaEsquerda)
        {
            while (cam.position.x > -8.88f)
            {
                cam.position = Vector3.MoveTowards(cam.position, showRight, step);
            }
        }
    }
}
