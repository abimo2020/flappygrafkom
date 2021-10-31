using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    float time = 0;
    float timer = 5;
    public GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(asteroid, transform.position, Quaternion.identity);
            time = timer;
        }
        else 
        {
            time -= Time.deltaTime;
        }
    }
}