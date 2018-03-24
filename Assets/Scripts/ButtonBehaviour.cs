using UnityEngine;
using System.Collections;
using UnityEngine.Sprites;


public class ButtonBehaviour : MonoBehaviour
{
    public bool Jogar;
    public bool jogar2;
    public bool creditos;
    public bool opcoes;
    public bool sair;
    public bool rejogar;
    public bool menu;
    public bool pulartuto;
    public bool fase2load;
    public bool setaDireita;
    public bool setaEsquerda;
    public bool tutorial1;
    public bool tutorial2;

    public GameObject[] SpriteGrande;

    // Use this for initialization
    void Start()
    {
    }


    void Update()
    {

    }
    void OnMouseEnter()
    {
        if (Jogar)
        {
            SpriteGrande[0].SetActive(true);
            Debug.Log("Amenta");
        }
        if (opcoes)
        {
            SpriteGrande[1].SetActive(true);
        }
        if (creditos)
        {
            SpriteGrande[2].SetActive(true);
        }
        if (rejogar)
        {
            SpriteGrande[3].SetActive(true);
        }
        if (menu)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (pulartuto)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (fase2load)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (setaDireita)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (setaEsquerda)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (jogar2)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (tutorial1)
        {
            SpriteGrande[0].SetActive(true);
        }
        if (tutorial2)
        {
            SpriteGrande[0].SetActive(true);
        }

    }
    void OnMouseExit()
    {
        if (Jogar)
        {
            SpriteGrande[0].SetActive(false);
            Debug.Log("Diminui");
        }
        if (opcoes)
        {
            SpriteGrande[1].SetActive(false);
        }
        if (creditos)
        {
            SpriteGrande[2].SetActive(false);
        }
        if (rejogar)
        {
            SpriteGrande[3].SetActive(false);
        }
        if (menu)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (pulartuto)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (fase2load)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (setaDireita)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (setaEsquerda)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (jogar2)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (tutorial1)
        {
            SpriteGrande[0].SetActive(false);
        }
        if (tutorial2)
        {
            SpriteGrande[0].SetActive(false);
        }
    }
    void OnMouseDown()
    {
        if (jogar2)
        {
            Application.LoadLevel("Tutorial fase 2");
        }
        if (Jogar)
        {
            Application.LoadLevel("Tutorial fase 1");
        }
        if (creditos)
        {
            Application.LoadLevel("");
        }
        if (opcoes)
        {
            Application.LoadLevel("Tutorial fase 1#");
        }
        if (sair)
        {
            Application.Quit();
        }
        if (menu)
        {
            Application.LoadLevel("Menu");
        }
        if (pulartuto)
        {
            Application.LoadLevel("jogo 1");
        }
        if (fase2load)
        {
            Application.LoadLevel("fase 2");
        }
        if (tutorial1)
        {
            Application.LoadLevel("tutorial1");
        }
        if (tutorial2)
        {
            Application.LoadLevel("tutorial2");
        }

    }
}
