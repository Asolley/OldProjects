using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextMap : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
              
	}

    // Update is called once per frame
    void Update()
    {       
        Enemeies();
        //print(transform.childCount);
    }
    void Enemeies()
    {

        if (transform.childCount <= 0)
        {
            endGame();
        }
    }
    void endGame()
    {
        SceneManager.LoadScene("Win");
    }   
}
