using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    float xMin;
    float xMax;
    public float padding = 1.0f;
    public GameObject projectile;
    public float shotSpeed;
    public float firingRate = 0.2f;
    public AudioClip fireSound;

    // Use this for initialization
    void Start()
    {
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, -10));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, -10));
        xMin = leftMost.x;
        xMax = rightMost.x;
    }

    // Update is called once per frame
    void Update()
        
    { 
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        float newX = Mathf.Clamp(transform.position.x, xMin + padding, xMax - padding);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Fire", 0.000001f, firingRate);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke("Fire");
        }

    }
    public void Fire()
    {
        GameObject shot = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        shot.GetComponent<Rigidbody2D>().velocity = new Vector3(0, shotSpeed, 0);
        AudioSource.PlayClipAtPoint(fireSound, transform.position);
    }
}
