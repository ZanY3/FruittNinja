using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruitApple;
    

    void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }
    void Spawn()
    {
       int rCount = Random.Range(0, 6);

       for (int i = 0; i < rCount; i++)
       {
            float rHeight = Random.Range(-5f, -4f);
            Vector3 rPos = new Vector3(Random.Range(-6f, 6f), rHeight, 0);
            var obj = Instantiate(fruitApple, rPos, Quaternion.identity);

        }
        
    }
}
