using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behavior_Chase : MonoBehaviour
{
   Transform player;
    Rigidbody2D myRigidbody;
    Vector3 home;
    public float moveSpeed;
    enum States {goHome, idle, chase};
    States state;
    
	// Use this for initialization
	void Start ()
    {
        home = transform.position;
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        state = States.idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == States.goHome)
        {
            MoveToward(home);
        }
        else if (state == States.chase)
        {
            MoveToward(player.position);
        }
        else if (state == States.idle)
        {
            myRigidbody.velocity = Vector3.zero;
        }
    }   

    void MoveToward(Vector3 target)
        { 
        Vector3 direction = target - transform.position;
        myRigidbody.velocity = direction.normalized * moveSpeed * Time.deltaTime;
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            state = States.idle;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == player.name)
        {
            state = States.chase;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == player.name)
        {
            state = States.goHome;
        }
    }

    void OnCollisionStay2D(Collision2D other)
       {
        if (other.gameObject.name == player.name)
        {
            state = States.idle;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.name == player.name)
        {
            state = States.chase;
        }
    }
}
