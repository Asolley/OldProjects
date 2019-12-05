using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadLevel(string name)
    {
        Debug.Log("level load requested for:" + name);
        Application.LoadLevel(name);
        SceneManager.LoadScene(name);
    }

}
