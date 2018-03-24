using UnityEngine;
using System.Collections;

public class DiminuiPlayer : MonoBehaviour
{
    public Transform player;
    public float scaleCheck;
    public static Vector3 playerPosition;
    private float insideTrigCounter = 0;
    public int contadorDinvoke;

    // Use this for initialization
    void Start() { contadorDinvoke = 0; }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            player.localScale = new Vector3(player.localScale.x - 0.05f, player.localScale.y - 0.05f, 1);
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        /*if (coll.gameObject.tag == "Enemy" || insideTrigCounter > 1)
        {

            insideTrigCounter = Time.deltaTime;
            player.localScale = new Vector3(player.localScale.x - 0.05f, player.localScale.y - 0.05f, 1);
        }*/
        Invoke("DimPlayer", 2);

    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            insideTrigCounter = 0;
        }
        CancelInvoke();
    }
    void DimPlayer()
    {
        player.localScale = new Vector3(player.localScale.x - 0.05f, player.localScale.y - 0.05f, 1);
        contadorDinvoke = +1;
    }
}