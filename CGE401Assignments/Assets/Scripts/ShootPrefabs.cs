/*
 * Scott Abbinanti
 * ShootPrefab
 * CGE 401 Prototype 2
 * Shoots food prefab out of player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefabs : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
