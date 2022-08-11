using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject preFab;

    public float TIMER = 5;
    public float  currentTime = 5;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime < 0)
        {
            Instantiate(preFab, spawnPoint.position, Quaternion.identity);
            currentTime = TIMER;
        }
    }
}
