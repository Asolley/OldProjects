using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehavior : MonoBehaviour
{
    public float health = 100f;    
    public GameObject projectile;
    public float shotSpeed;
    public float shotsPerSecond;
    public int scoreValue = 100;
    ScoreKeeper scoreKeeper;
    public AudioClip deathSound;
    // Use this for initialization
    void Start ()
    {
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float probability = Time.deltaTime * shotsPerSecond;
        if (Random.value < probability)
        {
            Fire();
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Projectile shot = col.GetComponent<Projectile>();
        if (shot)
        {
            health -= shot.GetDamage();
            shot.Hit();
            if(health <= 0)
            {
                Destroy(gameObject);
                scoreKeeper.IncreaseScore(scoreValue);
                
            }
        }   
    }
    public void Fire()
    {
        Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
        GameObject shot = Instantiate(projectile, startPosition, Quaternion.identity) as GameObject;
        shot.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -shotSpeed, 0);
        AudioSource.PlayClipAtPoint(deathSound, transform.position);

    }

}
