using UnityEngine;
using System.Collections;

public class DestroyPlayerEanimation : MonoBehaviour
{
    public int life;
    public Transform player;
    public GameObject ParticleTarget;

    //Som ao ser destruido e ao levar dano
    public AudioClip somDestruiu;
    //public AudioClip somLevouDano;

    // Use this for initialization
    void Start()  {}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
        if (life < 0)
        {
            life = 0;
        }
        if (life == 0)
        {
            player.localScale = new Vector3(player.localScale.x + 0.1f, player.localScale.y + 0.1f, 1);
            SoundManagerBehaviour.instance.RandomizeSfx(somDestruiu);
            Destroy(gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {   // destruir objeto 
        if (coll.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(ParticleTarget,
            gameObject.transform.position,
            gameObject.transform.rotation);

            GameControllerFase2.scorePoints += 10;
            
            
            //SoundManagerBehaviour.instance.PlaySingle(somDestruiu);
            

            Destroy(coll.gameObject);
            life -= 1;
        }
        if (coll.gameObject.tag == "Destroy")
        {
            Instantiate(ParticleTarget,
            gameObject.transform.position,
            gameObject.transform.rotation);

            Destroy(gameObject);
            Debug.Log("Era pra destruir");
        }
    }
   void Reset()
   {
      Application.LoadLevel("jogo 1");
   }
}
