﻿/*
* Chris Smith
* Assignment 2
* Allows the propeller to spin.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1000 * Time.deltaTime);
    }
}
