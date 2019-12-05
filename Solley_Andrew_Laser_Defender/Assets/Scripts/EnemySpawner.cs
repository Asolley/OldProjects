using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float width;
    public float height;
    public bool movingRight;
    public float speed;
    float xMin;
    float xMax;
    float spawnDelay = 0;

    // Use this for initialization
    void Start()
    {
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, -10));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, -10));
        xMin = leftMost.x;
        xMax = rightMost.x;
        SpawnUntilFull();
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height));
    }
    // Update is called once per frame
    void Update()
    {
       
        if (AllEnemiesAreDead())
        {
           int thisScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(thisScene +1);
        }

            if (movingRight)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        float rightEdgeOfFormation = transform.position.x + (0.5f * width);
        float leftEdgeOfFormation = transform.position.x - (0.5f * width);
        if (leftEdgeOfFormation < xMin)
        {
            movingRight = true;
        }
        else if (rightEdgeOfFormation > xMax)
        {
            movingRight = false;
        }
    }
    public bool AllEnemiesAreDead()
    {
        foreach (Transform childPosition in transform)
        {
            if (childPosition.childCount > 0)
            {
                return false;  
            }
        }
        return true;
    }
               

        Transform NextFreePosition() 
            {
            foreach (Transform childPosition in transform)
            {
                if (childPosition.childCount == 0)
                {
                    return childPosition; 
                }
            }
            return null;

    }	
    void SpawnUntilFull()
    {
        Transform freePosition = NextFreePosition();
        if (freePosition)
        {
            GameObject enemy = Instantiate(enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = freePosition;
        }
        if (NextFreePosition())
        {
            Invoke("SpawnUntilFull", spawnDelay);
        }
    }
}





 




