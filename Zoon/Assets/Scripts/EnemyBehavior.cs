using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{

    Transform player;
    Rigidbody2D myRigidbody;
    Vector3 destination;
    public enum PrimaryBehavior { wander, patrol }
    public enum SecondaryBehaviors { chase, evade }
    public enum States { chasing, evading, patrolling, wandering, waiting }
    public PrimaryBehavior primaryBehavior;
    public SecondaryBehaviors secondaryBehavior;
    States originalState;
    States currentState;
    float timeBetweenMoveCounter;
    public float timeBetwennMove;
    public float moveSpeed;
    public float wanderRange;
    public Transform[] wayPoints;
    int wayPointIndex;
    public float EnemyHealth = 500f;
    public float flashTime;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        destination = transform.position;
        if (primaryBehavior == PrimaryBehavior.wander)
        {
            originalState = States.wandering;
        }
        else if (primaryBehavior == PrimaryBehavior.patrol)
        {
            originalState = States.patrolling;
        }
        currentState = originalState;
    }
    void FlashRed()
    {        
        GetComponent<SpriteRenderer>().color = Color.red;
        Invoke("FlashReset", flashTime);
    }
    void FlashReset()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
        EnemyStates();
    }
    void EnemyStates()
    {
        //Debug.Log("My current state is" + currentState);
        if (currentState == States.wandering)
        {

            Wander();
        }
        else if (currentState == States.waiting)
        {
            Wait();
        }
        else if (currentState == States.chasing)
        {
            Chase(player.position);
        }
        else if (currentState == States.evading)
        {
            Evade();
        }
        else if (currentState == States.patrolling)
        {
            Partol();
        }
    }
    void Wander()
    {
        if (transform.position == destination)
        {
            currentState = States.waiting;
            destination = RandomDestination();
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        }
    }
    Vector3 RandomDestination()
    {
        Vector3 newDestination;
        newDestination = new Vector3(0 + Random.Range(-wanderRange, wanderRange), 1 + Random.Range(-wanderRange, wanderRange));
        return newDestination;
    }
    void Wait()
    {
        myRigidbody.velocity = Vector3.zero;
        timeBetweenMoveCounter -= Time.deltaTime;
        if (timeBetweenMoveCounter < 0)
        {
            timeBetweenMoveCounter = timeBetwennMove;
            currentState = originalState;
        }
    }
    void Chase(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            currentState = States.waiting;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == player.name)
        {
            if (secondaryBehavior == SecondaryBehaviors.chase)
            {
                currentState = States.chasing;
            }
            else if (secondaryBehavior == SecondaryBehaviors.evade)
            {
                currentState = States.evading;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == player.name)
        {
            currentState = States.waiting;
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        myRigidbody.simulated = false;      
        currentState = States.waiting;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        myRigidbody.simulated = true;       
    }
    void Evade()
    {
        Vector3 direction = transform.position - player.position;
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }
    void Partol()
    {
        if (transform.position == destination)
        {
            wayPointIndex = wayPointIndex + 1;
            if (wayPointIndex == wayPoints.Length)
            {
                wayPointIndex = 0;
            }
            destination = wayPoints[wayPointIndex].position;
            currentState = States.waiting;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
        }
    }  
    void OnCollisionEnter2D(Collision2D enemycol)
    {
        print("Inside Enemy Collision Enter");
        Projectile PlayerShot = enemycol.collider.GetComponent<Projectile>();        
        if (PlayerShot)
        {
            print("Enemy Hit");
            EnemyHealth -= PlayerShot.Projectiledamage();
            PlayerShot.DestroyProjectile();
            FlashRed();  
            if (EnemyHealth <= 0)
            {
                Destroy(gameObject);                
            }
        }
    }    
    
}

