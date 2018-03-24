using UnityEngine;
using System.Collections;

//Script que destrói objs se colidir com bullets
public class destroyPlayer : MonoBehaviour
{
    public int life;
    public Transform player;
    public GameObject ParticleTarget;
    private SpriteRenderer inim;

    //Som ao ser destruido e ao levar dano
    public AudioClip somDestruiu;
    public AudioClip somLevouDano;

    public bool mudacor = false;
    private bool comecacontar = false;
    public float contador;

    // Use this for initialization
    void Start() {
        inim = gameObject.GetComponent<SpriteRenderer>();
        comecacontar = false;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (comecacontar)
        {
            contador += Time.deltaTime;
        }
        if (contador < 0.2f && comecacontar)
        {
            inim.material.color = Color.red;
        }
        else
        {
            inim.material.color = Color.white;
            comecacontar = false;
            contador = 0;
        }
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
            Destroy(gameObject);

            Instantiate(ParticleTarget,
            gameObject.transform.position,
            gameObject.transform.rotation);

            //SoundManagerBehaviour.instance.RandomizeSfx(somDestruiu);
            //SoundManagerBehaviour.instance.efxSource.PlayOneShot(somDestruiu);
            SoundManagerBehaviour.instance.RandomizeSfx(somDestruiu);

            GameControllerFase2.scorePoints += 25;
            

        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    { // destruir objeto 
        if (coll.gameObject.tag.Equals("Bullet"))
        {
            life -= 1;
            Destroy(coll.gameObject);
            comecacontar = true;
            SoundManagerBehaviour.instance.RandomizeSfx(somLevouDano);

            //Para aparecerem partículas sempre que levar dano: (opcional)
            // Instantiate(ParticleTarget,
            // gameObject.transform.position,
            // gameObject.transform.rotation);
            
            

        }
        if (coll.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
            Instantiate(ParticleTarget,
            gameObject.transform.position,
            gameObject.transform.rotation);
            Debug.Log("Era pra destruir");
        }
    }
    void Reset()
    {
        Application.LoadLevel("jogo 1");
    }
}
