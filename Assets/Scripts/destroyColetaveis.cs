using UnityEngine;
using System.Collections;

public class destroyColetaveis : MonoBehaviour
{

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

        if (coll.gameObject.tag.Equals("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
