using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalReached : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Load Next lever here
        int thisScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(thisScene + 1);

    }
        
}
