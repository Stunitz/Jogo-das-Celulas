using UnityEngine;
using System.Collections;

public class GameController5 : MonoBehaviour
{

    public GameObject[] enemies; // array de inimigos
    public GameObject[] spawnPoints; // pontos de spawn

    public float timeToSpawn = 2;
    private float currentTime = 0;
    private int index;

    // Use this for initialization
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn5");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        SpawnEnemy();

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
