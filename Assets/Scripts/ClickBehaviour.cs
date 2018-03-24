using UnityEngine;
using System.Collections;

public class ClickBehaviour : MonoBehaviour {
    public bool Retry;
    public bool goMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if (Retry)
        {
            Application.LoadLevel("jogo 1");
        }
        if (goMenu)
        {
            Application.LoadLevel("Menu");
        }
    }
}
