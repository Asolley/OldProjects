using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for:" + name);
        SceneManager.LoadScene(name);        
    }
}
