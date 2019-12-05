using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterTouch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    Destroy(col.gameObject);
    //}
    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.tag == "Enemy")
        //{
        //    Destroy(col.gameObject);
        //}
        if (col.tag == "Player")
        {
            Destroy(col.gameObject);
            //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
