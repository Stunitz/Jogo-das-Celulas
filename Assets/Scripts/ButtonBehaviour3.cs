using UnityEngine;
using System.Collections;
using UnityEngine.Sprites;


public class ButtonBehaviour3 : MonoBehaviour
{
    public bool sim;
    public bool nao;
    public bool pula;
    public GameObject[] Sprite;

    // Use this for initialization
    void Start()
    {
        if (nao)
        {
            Sprite[0].SetActive(false);
        }
    }


    void Update()
    {

    }
    void OnMouseEnter()
    {
        if (sim)
        {
            Sprite[0].SetActive(true);
        }
        if (nao)
        {
            Sprite[0].SetActive(true);
        }
        if (pula)
        {
            Sprite[0].SetActive(true);
        }

    }
    void OnMouseExit()
    {
        if (sim)
        {
            Sprite[0].SetActive(false);
        }
        if (nao)
        {
            Sprite[0].SetActive(false);
        }
        if (pula)
        {
            Sprite[0].SetActive(false);
        }
    }
    void OnMouseDown()
    {
        if (sim)
        {
            Application.LoadLevel("fase 2");
        }
        if (nao)
        {
            Sprite[1].SetActive(false);
        }
        if (pula)
        {
            Sprite[1].SetActive(true);
        }
    }

}
