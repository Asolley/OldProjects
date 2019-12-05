using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
// Use this for initialization
    public float health = 100f;
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void PlayerDeath()
        {
        SceneManager.LoadScene("Menu");
        }
    public void OnTriggerEnter2D(Collider2D col)
    {
        Projectile shot = col.GetComponent<Projectile>();
        if (shot)
        {
            health -= shot.GetDamage();
            shot.Hit();
            if (health <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Lose");
            }
        }
    }
}
