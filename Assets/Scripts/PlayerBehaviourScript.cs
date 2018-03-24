using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerBehaviourScript : MonoBehaviour{


public float force = 10f; // Força aplicada no player
	private float directionX; // A  direçao em que o player andará private float direction; 
	private float directionY; // A  direçao em que o player andará 
    public float curredTime;
    public float curredTime2;
    public GameObject player;
    public GameObject GameOversprite;
    static public bool gameo;
    public Animator perdendo;
    public Text setPoints;
    public Text setFrase;

    //Sons ao coletar item e morrer
    public AudioClip somColetou;
    public AudioClip somMorreu;

	// Use this for initialization
	void Start () {
        curredTime = 11;
        curredTime2 = 0;
        Time.timeScale = 1;
        GameOversprite.SetActive(false);
        setFrase.text = "";
        setPoints.text = "";
        
	}

	// Update is called once per frame
	void Update () {
		// mostrar no console o valor da direçao 
		//print("Direção" + directionX);
        curredTime -= Time.deltaTime;
        curredTime2 += Time.deltaTime;
        if (curredTime < 0)
        {
            curredTime = 0;
        }
        if (curredTime == 0)
        {
            GameOver(true);
            
        }
        else
        {
            GameOver(false);
        }
        if(curredTime2>60)
        {
            curredTime2 = 0;
            MasterGameController.scorePoints += 50;
        }
        perdendo.SetFloat("Time", curredTime);
	}
	void FixedUpdate()
	{
		// x = direction * force * Time.deltaTime
		// y = ,0
		directionX = Input.GetAxis("Horizontal");
		directionY = Input.GetAxis ("Vertical");
		transform.Translate(new Vector2(directionX, directionY) * force * Time.deltaTime);

	}
    public void GameOver(bool Over)
    {
        if (Over)
        {
            if (MasterGameController.scorePoints < 100)
            {
                setFrase.text = "Se esforce mais da próxima vez";
            }else if (MasterGameController.scorePoints < 300)
            {
                setFrase.text = "Bom desempenho.";
            }else if (MasterGameController.scorePoints >= 301)
            {
                setFrase.text = "Resultado incrível, parabéns!!";
            }
            setPoints.text = "Sua Pontuação foi de:" +  MasterGameController.scorePoints + " pts";
            Time.timeScale = 0;
            gameo = true;
            GameOversprite.SetActive(true);
            Destroy(player);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    { // destruir objeto 
        if (coll.gameObject.tag.Equals("Coletavel"))
        {
            Destroy(coll.gameObject);
            MasterGameController.AddPoints(10);
            curredTime = 11;

            SoundManagerBehaviour.instance.RandomizeSfx(somColetou);
        }
        if(coll.gameObject.tag == "Enemy")
        {
            GameOver(true);
            SoundManagerBehaviour.instance.RandomizeSfx(somMorreu);
        }
    }
}
