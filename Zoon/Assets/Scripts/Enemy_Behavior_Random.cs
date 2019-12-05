using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior_Random : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    bool moving;
    Vector3 moveDirection;
    public float moveSpeed;
    public float timeBetweenMove;
    public float timeToMove;
    float timeBetweenMoveCounter;
    float timeToMoveCounter;
	// Use this for initialization
	void Start ()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = moveDirection;
            if (timeToMoveCounter < 0)
            {
                moving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
            }                 
        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector3.zero;
            if (timeBetweenMoveCounter < 0)
            {
                moving = true;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f); 
                moveDirection = new Vector3(Random.Range(-1.0f, 1.0f) * moveSpeed, 1);
            }
        }
	}
}
