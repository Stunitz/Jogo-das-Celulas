using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GameObject[] enemies; // array de inimigos
    public GameObject[] spawnPoints; // pontos de spawn

    public float timeToSpawn = 3;
    private float currentTime = 0;
    private float currentTime2 = 0;
    private int index;
    private bool Aum = true;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
        timeToSpawn = 3;
        currentTime2 = 0;
        currentTime = 0;
        EnemyBehaviourdown.speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        currentTime2 += Time.deltaTime;

        SpawnEnemy();
        Aumentando();

    }
    void Aumentando()
    {
        if (currentTime2 > 10 && Aum)
        {
            currentTime2 = 0;
            timeToSpawn -= 0.5f;
            if (timeToSpawn < 2.25f)
            {
                Aum = false;
            }
            if(EnemyBehaviourdown.speed < 6 )
            {
                EnemyBehaviourdown.speed += 0.5f;
            }
        }
    }
    void SpawnEnemy()
    {
        // gerar um valor aleatório para a variavel index:
        index = Random.Range(0, spawnPoints.Length);

        // instanciar um inimigo (inicialmente na posição zero)
        // do array de inimigos:
        if (currentTime > timeToSpawn)
        {
            Instantiate(enemies[0],
                spawnPoints[index].transform.position,
                enemies[0].transform.rotation);

            currentTime = 0;
        }
    }
}
