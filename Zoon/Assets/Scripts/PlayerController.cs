using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rBody;
    Animator anim;
    public GameObject projectile;
    public float shotSpeed =  0.2f;
    public float firingDelay = 0.2f;
    public float PlayerHealth = 500f;
    // Use this for initialization
    void Start ()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();       
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }    
    void Movement()
            {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 fire_vector = new Vector2(Input.GetAxisRaw("Fire1"), Input.GetAxisRaw("Fire2"));


        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
            rBody.MovePosition(rBody.position + movement_vector * Time.deltaTime);

            if (anim.GetBool("isAttacking"))
            {
                anim.SetFloat("input_x", fire_vector.x);
                anim.SetFloat("input_y", fire_vector.y);
            }
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        
        }   
    void Shoot()
    {
        Vector2 fire_vector = new Vector2(Input.GetAxisRaw("Fire1"), Input.GetAxisRaw("Fire2"));
        //Debug.Log("fire_vector: " + fire_vector.ToString());
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("isAttacking", true);
            anim.SetFloat("input_x", fire_vector.x);
            anim.SetFloat("input_y", fire_vector.y);
            InvokeRepeating("Fire", 0.000001f, firingDelay);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isAttacking", true);
            anim.SetFloat("input_x", fire_vector.x);
            anim.SetFloat("input_y", fire_vector.y);
            InvokeRepeating("Fire", 0.000001f, firingDelay);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("isAttacking", true);
            anim.SetFloat("input_x", fire_vector.x);
            anim.SetFloat("input_y", fire_vector.y);
            InvokeRepeating("Fire", 0.000001f, firingDelay);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("isAttacking", true);
            anim.SetFloat("input_x", fire_vector.x);
            anim.SetFloat("input_y", fire_vector.y);
            InvokeRepeating("Fire", 0.000001f, firingDelay);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("isAttacking", false);
            CancelInvoke("Fire");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isAttacking", false);
            CancelInvoke("Fire");
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("isAttacking", false);
            CancelInvoke("Fire");
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isAttacking", false);
            CancelInvoke("Fire");
        }
    }
    void OnCollisionEnter2D(Collision2D playerCol)
    {
        print("Inside  PlayerCollision enter");              
        EnemyAttacking EnemyHitting = playerCol.collider.GetComponent<EnemyAttacking>();
        if (EnemyHitting)
       {
            print("Player Hit");
            PlayerHealth -= EnemyHitting.EnemyDamage();
        }
        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
    //void OnTriggerEnter2D(Collider2D other)//This will be for melee combat
    //{
    //    if (anim.GetBool("isAttacking"))
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}
    void Fire()
    {
        GameObject shot = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        shot.GetComponent<Rigidbody2D>().velocity = new Vector3(Input.GetAxisRaw("Fire1") * shotSpeed, Input.GetAxisRaw("Fire2") * shotSpeed);
    }    
}
