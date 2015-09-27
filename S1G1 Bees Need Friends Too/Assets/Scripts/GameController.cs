using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int score = 0;
    public float timeS = 59;
    public int timeM = 1;

    bool isPlaying;

    public Text timerText;

	// Use this for initialization
	void Start () {
        isPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {

        timerText.text = timeM.ToString("0") + " : " + timeS.ToString("00");

        if(isPlaying)
        {
            timeS -= Time.deltaTime * 1;

            if(timeS <= 0.01f)
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
}
