using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
    static int score;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }
    public void Reset()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
