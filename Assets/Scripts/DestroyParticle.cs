using UnityEngine;
using System.Collections;

//Este script deve estar no sistema de particulas. O sistema de partículas será destruido após 
//um numero de segundos.
public class DestroyParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        Invoke("DestroyAfterSecs", 1);
	}
    void DestroyAfterSecs()
    {
        Destroy(gameObject);
    }
}
