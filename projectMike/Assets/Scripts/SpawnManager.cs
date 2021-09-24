using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPoint;
    [SerializeField]
    GameObject objectPrefab; 
    // Start is called before the first frame update
    void Start()
    {   //spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        spawnPoint = GameObject.FindGameObjectsWithTag("SpawnPoint"); 
        foreach (GameObject spawn in spawnPoint)
        {
            GameObject spawnObj = Instantiate(objectPrefab, spawn.transform, false);
            objectScript objScript = spawnObj.GetComponent<objectScript>();
            objScript.floatSpeed = Random.Range(1, 3);
            int randomNum = Random.Range(1, 4);
            if (randomNum <=2)
            {
                objScript.isCorrect = true;
            } else
            {
                objScript.isCorrect = false; 
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
