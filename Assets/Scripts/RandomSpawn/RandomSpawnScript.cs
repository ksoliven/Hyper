using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject star, enemy1, enemy2;
    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn){
            whatToSpawn = Random.Range(1,3);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
;                    Instantiate(star, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(enemy1, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(enemy2, transform.position, Quaternion.identity);
                    break;
              
            }

            nextSpawn = Time.time + spawnRate;
                        
          }

        }
    }

