using UnityEngine;
using System.Collections;
public class Instanciador : MonoBehaviour
{
    public Transform[] Destinos; // linke os destinos aleatorios aqui
    public GameObject[] Objetos; // linke os objetos aleatorios aqui
    private float cronometro;
    public float tempoPorSpawn;
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro >= tempoPorSpawn)
        {
            Instantiate(Objetos[Random.Range(0, Objetos.Length)], Destinos[Random.Range(0, Destinos.Length)].transform.position, transform.rotation);
            cronometro = 0;
        }
    }
}