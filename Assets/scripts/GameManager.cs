using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject startGame;
    public GameObject scoreView;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;    
    }

    public void StartGame(){
        Time.timeScale = 1;
        startGame.SetActive(true);
        startGame.SetActive(false);
    }

    public void ScoreView(){
        Time.timeScale = 1;
        scoreView.SetActive(true);
    }

    public void GameOver(){
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }
}
