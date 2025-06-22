using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class TankSpawners : MonoBehaviour
{ 
    [SerializeField] private List<GameObject> tanksSpawners;
    [SerializeField] private GameObject tankPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        int seed = DateTime.Now.Millisecond + (int)(Time.time * 1000);
        Random rnd = new Random(seed);

        int randomInt = rnd.Next(0, tanksSpawners.Count);
        Instantiate(tankPrefab, tanksSpawners[randomInt].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
