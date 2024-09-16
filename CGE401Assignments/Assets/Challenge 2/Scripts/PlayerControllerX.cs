/*
 * Scott Abbinanti
 * PlayerControllerX
 * CGE 401 Challenge 2
 * Allows player to shoot dogs at balls
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float CoolDownTime = 1.0f;
    private float coolDownUntilNextPress;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDownUntilNextPress < Time.time)
        {
            coolDownUntilNextPress = Time.time + CoolDownTime;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
