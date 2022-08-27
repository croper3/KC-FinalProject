using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] cactuses;
    public Transform spawnpoints;

    private int rand;


    public float starttimebtwspawns;
    public float timebtwspawns;


    private void Start()
    {

        InvokeRepeating("spawnenemy", 0f, timebtwspawns);
    }

    private void Update()
    {
       
    }
    void spawnenemy()
    {
       
        int randNum = Random.Range(0, 3);
        
            Instantiate(cactuses[randNum], spawnpoints.transform);
   
    }
}
