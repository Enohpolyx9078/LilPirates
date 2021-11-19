using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStuffSpawner : MonoBehaviour
{
    public ObjectPool thingPool;
    private float screenWidth;
    private float screenHeight;

    private float offset;
    public float spawnRate;

    private void Awake() 
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        //Invoke a repeating function to spawn things every spawnRate seconds
        InvokeRepeating("Spawn", 3, spawnRate);
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawns an object from the object pool
    void Spawn()
    {
        //choose a random integer 1-2 and assign it to offset
        //offset = Random.Range(1, 2);
        offset = 0;
        //Get a random position off the screen
        Vector3 spawnPos = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.5f, 60.0f));
        //Get a random object from the object pool
        GameObject thing = thingPool.GetObject();
        //Set the object's position to the random position
        thing.transform.position = spawnPos;
        //Set the object's active state to true
        thing.SetActive(true);
    }

}
