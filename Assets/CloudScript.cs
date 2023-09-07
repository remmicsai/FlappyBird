using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float cloudSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomSpeed = Random.Range(3, 6);

        transform.position = transform.position - (Vector3.right * randomSpeed) * Time.deltaTime;
        //transform.Translate(Vector3.right * (Time.deltaTime * cloudSpeed)); 
    }
}
