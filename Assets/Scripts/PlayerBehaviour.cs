using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed; // determina a velocidade de deslocamento
    private float direction1; // irá capturar a direção de deslocamento
    private float direction2;

    // Variáveis de disparo [2º grupo de variáveis]
    public GameObject[] bullets; // a bullet que será disparada
    public Transform spawnPoint; // o ponto de origem da bullet

    // variáveis para controlar a cadência de tiro (fireRate) [3º grupo de variáveis]:
    public float fireRate; // taxa de disparo (determina o tempo entre um disparo e outro)
    private float currentTime; // contador que irá contar o tempo decorrente entre um disparo e outro
    public float curredTime2;

    // variáveis para trabalhar com os sons [4º grupo de cariáveis]:
    public AudioClip[] shotSounds; // som do disparo do tiro pricipal
    private AudioSource playerAudio; // gerenciador de audio
    //Sons ao atirar
    public AudioClip somAtirou;

    public int index = 0; // corresponde ao indice dos arrays:
    public Transform player;
    public float scaleCheck;
    public static Vector3 playerPosition;

    public GameObject ParticleTarget;

    public Text setPoints;
    public Text setFrase;
    //public Text textScore;

    public bool jogadorvivo = false;

    public GameObject GameOver2sprite;
    static public bool gameo = false;

    public int Playermorto;

    


    // Use this for initialization
    void Start()
    {
        // inicializar componentes:

        setFrase.text = "";
        setPoints.text = "";
        //textScore.text = "";
        curredTime2 = 0;
        
        currentTime = 0;
        // capturar os componentes necessários:
        playerAudio = GetComponent<AudioSource>();
        player.localScale = new Vector3(1, 1, 1);

        Playermorto = 0;
        GameOver2sprite.SetActive(false);

        Time.timeScale = 1;
    }
    void Update()
    {
        // 6º Passo: incrementar o valor de 'currentTime':
        currentTime += Time.deltaTime;
        curredTime2 += Time.deltaTime;
        playerPosition = transform.position;

        if (Playermorto < 0)
        {
            Playermorto = 0;
        }
        if (Playermorto == 1)
        {
            //textScore.text = "Score: " + curredTime2 + " segundos.";// Pontuação fase 2
            GameOver(true);
        }

        else
        {
            GameOver(false);
        }

        if (curredTime2 > 60)
        {
            curredTime2 = 0;
            GameControllerFase2.scorePoints += 50;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Fire();
        Move();
        if (player.localScale.x < scaleCheck && player.localScale.y < scaleCheck)
        {
            player.localScale = new Vector3(scaleCheck, scaleCheck, 1);
        }
        if (player.localScale.x == scaleCheck && player.localScale.y == scaleCheck)
        {
            if (GameControllerFase2.scorePoints < 100)
            {
                setFrase.text = "Se esforce mais da próxima vez";
            }
            else if (GameControllerFase2.scorePoints < 300)
            {
                setFrase.text = "Bom desempenho.";
            }
            else if (GameControllerFase2.scorePoints >= 301)
            {
                setFrase.text = "Resultado incrível, parabéns!!";
            }
            setPoints.text = "Sua Pontuação foi de: " + GameControllerFase2.scorePoints + " pts";

            Destroy(gameObject);
            Playermorto = 1;
            GameOver2sprite.SetActive(true);
            Time.timeScale = 0;

            //  Instantiate(ParticleTarget,
            // gameObject.transform.position,
            // gameObject.transform.rotation);

        }
    }
    void Fire()
    {
        // se clicou E o tempo decorrido for maior que o fire rate:
        if (Input.GetMouseButtonDown(0) && currentTime > fireRate)
        {
            // instancia objeto 'bullet' no jogo
            // Instanciar (objeto, neste ponto de origem, com a rotação do proprio objeto)
            Instantiate(bullets[index], spawnPoint.position, bullets[index].transform.rotation);
            player.localScale = new Vector3(player.localScale.x - 0.05f, player.localScale.y - 0.05f, 1);
            
            // cada vez que for disparado uma bullet, o currentTime é zerado:
            currentTime = 0;

            // 8º Passo: reproduzir o som de disparo:
            //playerAudio.PlayOneShot(shotSounds[index], 0.4f);
            SoundManagerBehaviour.instance.RandomizeSfx(somAtirou);
        }
    }
    void Move()
    {
        // movimentaçao do personagem
        // capturar a direção de deslocamento:
        direction1 = Input.GetAxis("Horizontal");
        direction2 = Input.GetAxis("Vertical");

        // movimentar o player:
        transform.Translate(new Vector2(direction1, direction2) * speed * Time.deltaTime);

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Instantiate(bullets[index], spawnPoint.position, bullets[index].transform.rotation);
            player.localScale = new Vector3(player.localScale.x - 0.05f, player.localScale.y - 0.05f, 1);
        }
    }
    public void GameOver(bool Over)
    {
        if (Over)
        { 
           
            

            gameo = true;
            GameOver2sprite.SetActive(true);
            Destroy(player);
            Time.timeScale = 0;
        }
        if (Playermorto >= 1)
        {
            GameOver2sprite.SetActive(true);
            Destroy(player);
            Time.timeScale = 0;
        }
    }
}