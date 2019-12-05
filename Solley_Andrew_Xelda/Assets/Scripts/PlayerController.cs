using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rBody;
    Animator anim;

	// Use this for initialization
	void Start ()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement_vector != Vector2.zero && anim.GetBool("isAttacking")== false)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
            rBody.MovePosition(rBody.position + movement_vector * Time.deltaTime);
        }

        else
        {
            anim.SetBool("isWalking", false);
        }
        if (Input.GetButton("Fire1"))
        {
            anim.SetBool("isAttacking", true);
            anim.SetBool("isWalking", false);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("isAttacking", false);
        }
      }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (anim.GetBool("isAttacking"))
        {
            Destroy(other.gameObject);
        }

    }
   }
