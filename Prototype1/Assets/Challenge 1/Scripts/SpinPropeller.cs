/*
 * Scott Abbinanti
 * SpinPropeller
 * CGE 401 Challenge 1
 * Allows the propeller to spin realistically
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float degrees = 140;


    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.localEulerAngles;
        rotation.z += Time.deltaTime * degrees;
        transform.localEulerAngles = rotation;
    }
}
