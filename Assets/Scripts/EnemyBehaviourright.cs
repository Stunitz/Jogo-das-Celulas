using UnityEngine;
using System.Collections;

public class EnemyBehaviourright : MonoBehaviour
{
    public static float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveDireita(speed);
    }
    public void MoveDireita(float velocidade)
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }
}
