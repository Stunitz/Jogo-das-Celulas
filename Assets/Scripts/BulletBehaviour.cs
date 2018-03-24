using UnityEngine;
using System.Collections;

public abstract class BulletBehaviour : MonoBehaviour
{
    // 1º Passo: criação das variáveis e atributos:

    // velocidade de deslocamento
    public float speed = 7;

    // variável para determinar o tempo de vida da bullet
    public int lifeTime = 2;

    public int damage; // dano da bullet


    public void DestroyBullet()
    {
        // Destruir a bullet após 'x' segundos, onde 'x' será representado pela 
        // variável lifeTime:
        Destroy(gameObject, lifeTime);
    }

    public void Move()
    {
        
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public void Mirateste()
    {
        transform.up = ShotBehaviour.miraBala;
    }
    // método que testa colisao com alguma coisa:
    void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);


        // se o objeto que a bullet colidiu não possuir a tag 'bullet'
        if (coll.gameObject.tag != "Bullet" &&
            coll.gameObject.tag != "Player")
        {
            // destroy a bullet:
            Destroy(gameObject);
        }

    }


}
