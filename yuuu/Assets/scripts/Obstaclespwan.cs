using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespwan : MonoBehaviour
{
    public GameObject kaktus, duri, batu2, burung, pokemon;
    private float obstacleSpawnInterval = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstacles");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnObstacle()
    {
        int random = Random.Range(1,6);
        if (random == 1)
        {
            Instantiate(kaktus, new Vector3(transform.position.x, -3.05f, 0), Quaternion.identity);
        }

        else if (random == 2)
        {
            Instantiate(duri, new Vector3(transform.position.x, -3.946252f, 0), Quaternion.identity);
        }

        else if (random == 3)
        {
            Instantiate(batu2, new Vector3(transform.position.x, -3.39f, 0), Quaternion.identity);
        }
        else if (random == 4)
        {
            Instantiate(burung, new Vector3(transform.position.x, -1.4f, 0), Quaternion.identity);
        }
        else if (random == 5)
        {
            Instantiate(pokemon, new Vector3(transform.position.x, -3.783372f, 0), Quaternion.identity);
        }
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(obstacleSpawnInterval);
        }
    }
}
