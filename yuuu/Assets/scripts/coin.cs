using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject koin,koin2,koin3,koin4,koin5;
    private float koinSpawnInterval = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCoins");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SpawnCoin()
    {
        int random = Random.Range(1, 6);
        if (random == 1)
        {
            Instantiate(koin, new Vector3(transform.position.x, -2.6f, 0), Quaternion.identity);
        }

        else if (random == 2)
        {
            Instantiate(koin2, new Vector3(transform.position.x, -3.04f, 0), Quaternion.identity);
        }

        else if (random == 3)
        {
            Instantiate(koin3, new Vector3(transform.position.x, -2.08f, 0), Quaternion.identity);
        }
        else if (random == 4)
        {
            Instantiate(koin4, new Vector3(transform.position.x, -0.25f, 0), Quaternion.identity);
        }
        else if (random == 5)
        {
            Instantiate(koin5, new Vector3(transform.position.x, -1.68f, 0), Quaternion.identity);
        }
    }

    IEnumerator SpawnCoins()
    {
        while (true)
        {
            SpawnCoin();
            yield return new WaitForSeconds(koinSpawnInterval);
        }
    }

}
