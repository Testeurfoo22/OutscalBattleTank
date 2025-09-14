using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Script;
using UnityEngine;
using Random = System.Random;

public class TankSpawners : MonoBehaviour
{ 
    [SerializeField] private List<GameObject> tanksSpawners;
    [SerializeField] private TankViewer tankViewer;


    public Vector3 camPosition;

    [Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public TankTypes type;

        public Material color;
    }
    
    public List<Tank> tankList;
    public int selectedTank;
    
    // Start is called before the first frame update
    void Start()
    {
        int seed = DateTime.Now.Millisecond + (int)(Time.time * 1000);
        Random rnd = new Random(seed);
        
        int randomSpawn = rnd.Next(0, tanksSpawners.Count);
        int randomTank = rnd.Next(0, tankList.Count);

        CreateTank(tankList[randomTank], tanksSpawners[randomSpawn]);
        
        /*foreach (Tank tank in tankList)
        {
            List<int> validIndices = Enumerable.Range(0, tanksSpawners.Count)
                .Where(i => !_excludesSpawn.Contains(i))
                .ToList();
            int randomInt = rnd.Next(0, validIndices.Count);
            CreateTank(tank, tanksSpawners[randomInt]);
        }*/
    }

    // Update is called once per frame
    void CreateTank(Tank tank, GameObject randomInt)
    {
        TankController tankController = new TankController(new TankModel(tank), tankViewer, randomInt);
    }
}