using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float noSpawn;

    private const float TimeBetweenShots = 0.5f;  // seconds

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        if (noSpawn > 0)
        {
            noSpawn -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
            { 
            // can we spawn yet?
            if (noSpawn <= 0)
            {

                noSpawn = TimeBetweenShots;

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }


    }
}
