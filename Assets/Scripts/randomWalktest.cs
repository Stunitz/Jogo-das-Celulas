using UnityEngine;
using System.Collections;

//Este Script Movimenta um GameObject em direções aleatórias.
//NOTA: usar também aquele script que gira o Obj na direção que ele se movimenta.
public class randomWalktest : MonoBehaviour
{
    public int random; // = Random.Range(1, 3);
    public int speed;
    public float curredTime = 2;
    // Use this for initialization
    void Start()
    {
        curredTime = 2;
        speed = 15;

        //random = Random.Range(0, 5);

    }

    // 
    void FixedUpdate()
    {
        //random = Random.Range(0, 5); Invoke("walkRandomDirection", 3);
        //InvokeRepeating("CriaNumAleatParaDirecao", 2, 4);
        //---------O valor random deve aparecer de tantos em tantos segundos, para
        //ativar uma dentre 4 possiveis direcoes.
        //walkRandomDirection();
        curredTime -= Time.deltaTime;
        if (curredTime < 0)
        {
            curredTime = 0;
        }
        if (curredTime == 0)
        {
            CriaNumAleatParaDirecao();

            curredTime = 2;
        }
        //transform.Translate(Vector2.left * speed * Time.deltaTime);
        walkRandomDirection();
    }
    void walkRandomDirection()
    {
        if (random == 0) { transform.Translate(Vector2.left * speed * Time.deltaTime); }
        else if (random == 1) { transform.Translate(Vector2.right * speed * Time.deltaTime); }
        else if (random == 2) { transform.Translate(Vector2.up * speed * Time.deltaTime); }
        else if (random == 3) { transform.Translate(Vector2.down * speed * Time.deltaTime); }
    }
    void CriaNumAleatParaDirecao()
    {
        random = Random.Range(0, 4);
    }
}
