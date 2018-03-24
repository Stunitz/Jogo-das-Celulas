using UnityEngine;
using System.Collections;

public class enemy2 : MonoBehaviour
{

    public Vector3 tar;
    public float moveSpeed = 3;
    private Vector3 player;
    public GameObject play;

    void Start()
    {

    }

    void Update()
    {
        tar = PlayerBehaviour.playerPosition;
        Chase();
    }

    void Chase()
    {
        //Vector3 targetDirection = target.position - transform.position;
        //transform.position += targetDirection * moveSpeed * Time.deltaTime;
        
        player = transform.position;
        transform.up = (player - tar);
        

        //miraBala = (mousePos - transform.position);
        //transform.up = miraBala;
    }
}