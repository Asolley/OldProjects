using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectiledamage = 25f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public float Projectiledamage()
    {
        return projectiledamage;
    }
    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }

}
