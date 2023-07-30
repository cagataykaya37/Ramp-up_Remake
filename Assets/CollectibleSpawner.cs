using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    int spawnCount, spawnLocation, spawnItem1, spawnItem2, spawnItem3;
    Transform s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
    GameObject starPrefab, lifePrefab;

    // Start is called before the first frame update
    void Start()
    {
        s1 = GameObject.Find("S1").GetComponent<Transform>();
        s2 = GameObject.Find("S2").GetComponent<Transform>();
        s3 = GameObject.Find("S3").GetComponent<Transform>();
        s4 = GameObject.Find("S4").GetComponent<Transform>();
        s5 = GameObject.Find("S5").GetComponent<Transform>();
        s6 = GameObject.Find("S6").GetComponent<Transform>();
        s7 = GameObject.Find("S7").GetComponent<Transform>();
        s8 = GameObject.Find("S8").GetComponent<Transform>();
        s9 = GameObject.Find("S9").GetComponent<Transform>();
        s10 = GameObject.Find("S10").GetComponent<Transform>();
        starPrefab = Resources.Load<GameObject>("StarPrefab");
        lifePrefab = Resources.Load<GameObject>("LifePrefab");

        spawnCount = Random.Range(0,4);
        //spawnLocation = Random.Range(1,11);
        //spawnItem1 = Random.Range(1, 3);
        //spawnItem2 = Random.Range(1, 3);
        //spawnItem3 = Random.Range(1, 3);

        if (spawnCount == 1)
        {
            spawnMethod();
        }
        else if(spawnCount == 2)
        {
            spawnMethod();
            spawnMethod();
        }
        else if (spawnCount == 3)
        {
            spawnMethod();
            spawnMethod();
            spawnMethod();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnMethod()
    {
        spawnItem1 = Random.Range(1, 3);
        spawnLocation = Random.Range(1, 11);

        switch (spawnLocation)
        {
            case 1:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s1);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s1);
                }
                break;
            case 2:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s2);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s2);
                }
                break;
            case 3:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s3);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s3);
                }
                break;
            case 4:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s4);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s4);
                }
                break;
            case 5:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s5);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s5);
                }
                break;
            case 6:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s6);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s6);
                }
                break;
            case 7:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s7);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s7);
                }
                break;
            case 8:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s8);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s8);
                }
                break;
            case 9:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s9);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s9);
                }
                break;
            case 10:
                if (spawnItem1 == 1)
                {
                    Instantiate(starPrefab, s10);
                }
                else if (spawnItem1 == 2)
                {
                    Instantiate(lifePrefab, s10);
                }
                break;
            default:
                break;
        }

    }

}
