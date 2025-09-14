using System;
using System.Collections.Generic;
using System.Linq;
using Script;
using UnityEngine;
using Random = System.Random;

public class TankSpawners : MonoBehaviour
{ 
    [SerializeField] private List<GameObject> tanksSpawners;
    [SerializeField] private TankViewer tankViewer;

    public Vector3 camPosition;
    public Vector3 camRotation;
    
    public List<Tank> tankList;
    
    // Start is called before the first frame update
    public void OnTankSelected(TankTypes tankType)
    {
        int seed = DateTime.Now.Millisecond + (int)(Time.time * 1000);
        Random rnd = new Random(seed);
        
        int randomSpawn = rnd.Next(0, tanksSpawners.Count);
        //int randomTank = rnd.Next(0, tankList.Count);
        Tank tank = tankList.FirstOrDefault(obj => obj.Type == tankType);

        CreateTank(tank, tanksSpawners[randomSpawn]);
    }

    // Update is called once per frame
    void CreateTank(Tank tank, GameObject randomInt)
    {
        TankController _ = new TankController(new TankModel(tank), tankViewer, randomInt);
    }
}