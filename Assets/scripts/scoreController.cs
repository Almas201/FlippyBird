using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public birdController birdController;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            score++;
            birdController.PointSoundPlay();
        }
    }
    
    
}
