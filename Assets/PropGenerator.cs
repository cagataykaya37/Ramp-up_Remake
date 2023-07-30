using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropGenerator : MonoBehaviour
{
    public GameObject small1, small2, mid1, mid2, big1;

    int objectNumber;
    float timer;
    float spawnLoc;

    bool control = true;

    Vector3 propSpawnLoc;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(control == true)
        {
            timer = Random.Range(10, 35);
            objectNumber = Random.Range(1, 12);
            spawnLoc = Random.Range(-100, 101);
            propSpawnLoc = new Vector3(spawnLoc/100, 4.2f, 3.6f);
            control = false;
            StartCoroutine(propSpawn());
        }
        
    }

    IEnumerator propSpawn()
    {
        if(control == false)
        {
            yield return new WaitForSeconds(timer / 100);
            switch (objectNumber)
            {
                case 1:
                case 2:
                case 3:
                    Instantiate(small1, propSpawnLoc, new Quaternion(Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181)));
                    control = true;
                    break;
                case 4:
                case 5:
                case 6:
                    Instantiate(small2, propSpawnLoc, new Quaternion(Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181)));
                    control = true;
                    break;
                case 7:
                case 8:
                    Instantiate(mid1, propSpawnLoc, new Quaternion(Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181)));
                    control = true;
                    break;
                case 9:
                case 10:
                    Instantiate(mid2, propSpawnLoc, new Quaternion(Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181)));
                    control = true;
                    break;
                case 11:
                    Instantiate(big1, propSpawnLoc, new Quaternion(Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181), Random.Range(0, 181)));
                    control = true;
                    break;
                default:
                    break;
            }
            //control = true;
        }
    }

}
