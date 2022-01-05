using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum IslandTime
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class IslandLoader : MonoBehaviour
{
    public IslandTime season;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            switch(season)
                {
                    case IslandTime.Spring:
                        break;

                    case IslandTime.Summer:
                        SceneManager.LoadScene("Summer Island");
                        break;

                    case IslandTime.Autumn:
                        break;

                    case IslandTime.Winter:
                        break;
                }
        }
    }
}
