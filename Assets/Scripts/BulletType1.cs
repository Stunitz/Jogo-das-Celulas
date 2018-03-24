using UnityEngine;
using System.Collections;

public class BulletType1 : BulletBehaviour
{
    public float speedUp = 0.02f;

    // Use this for initialization
    void Start()
    {
        Mirateste();
    }

    // Update is called once per frame
    void Update()
    {
        // chamando o método responsavel por destruir a bullet:
        DestroyBullet();

        // incrementar a velocidade:
        speed += speedUp;

    }

    void FixedUpdate()
    {
        // chamando o método responsavel por mover a bullet:
        Move();
    }


}
