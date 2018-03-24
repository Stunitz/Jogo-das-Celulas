using UnityEngine;
using System.Collections;

public class GameController3 : MonoBehaviour
{

    public GameObject[] enemies; // array de inimigos
    public GameObject[] spawnPoints; // pontos de spawn

    public float timeToSpawn = 15;
    private float currentTime = 0;
    private float currentTime2 = 0;
    private int index;
    private bool Aum = true;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn3");
        timeToSpawn = 15;
        currentTime2 = 0;
        currentTime = 0;
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
