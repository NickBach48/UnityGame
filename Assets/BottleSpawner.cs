using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawner : MonoBehaviour
{
    public GameObject bottle;
    public float spawnRate = 2;
    private float counter = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < spawnRate)
        {
            counter += Time.deltaTime;
        }
        else
        {
            Spawn();
            counter = 0;
        }
      
        
    }

    void Spawn()
    {
        Instantiate(bottle, new Vector3(transform.position.x, Random.Range(-4,6),0), transform.rotation);
    }
}
