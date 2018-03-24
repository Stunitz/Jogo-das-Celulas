using UnityEngine;
using System.Collections;

public class DestroyPlayer2 : MonoBehaviour
{
    public int life;
    public Transform player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    { // destruir objeto 
        if (coll.gameObject.tag.Equals("enemy"))
        {

            Destroy(coll.gameObject);
            life -= 1;
        }
        if (coll.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }
    void Reset()
    {
        Application.LoadLevel("jogo 2");
    }
}
