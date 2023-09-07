using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        float randomSpeed = Random.Range(0, 4);      
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(-20, 20), 0), transform.rotation);
        //Instantiate(pipe, new Vector3(transform.position.x, Random.Range(0, 2), 0), transform.rotation);
    }
}
