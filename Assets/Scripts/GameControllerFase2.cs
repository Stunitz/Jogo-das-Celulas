using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControllerFase2 : MonoBehaviour {

    public static int scorePoints;
    //public Text scoreText;
    
    // Use this for initialization
    void Start() { scorePoints = 0; }

    // Update is called once per frame
    void Update(){
        //SetScorePoints();
    }

    public static void AddPoints(int points)
    {
        // alterar pontos no placar
        scorePoints += points;
    }
    /*void SetScorePoints()
    {
        scoreText.text = "Score: " + scorePoints + " pts";
    }*/
}
