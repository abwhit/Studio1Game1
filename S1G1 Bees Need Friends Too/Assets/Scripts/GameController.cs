using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

   

    // Information about storing the time
    public float timeS = 59;
    public int timeM = 1;

    // Bool to check if the game is playing
    bool isPlaying;

    // Storing the timerText
    public Text timerText;

    // Storing the score and the score text
    public int score = 0;
    public Text scoreText;

    public bool beesAreClose;

    

    void Awake()
    {
        


    }

    // Use this for initialization
    void Start () {
        isPlaying = true;
        beesAreClose = false;
	}
	
	// Update is called once per frame
	void Update () {

        timerText.text = timeM.ToString("0") + ":" + timeS.ToString("00");

        scoreText.text = "Score: " + score.ToString();


        if (isPlaying)
        {
            timer();
              
        }

	
	}

    void timer()
    {
        timeS -= Time.deltaTime * 1;

        if (timeS <= 0.01f)
        {
            timeS = 59f;
            timeM -= 1;

        }
        if (timeM < 0)
        {
            Debug.Log("GameOver");
        }

    }
}
