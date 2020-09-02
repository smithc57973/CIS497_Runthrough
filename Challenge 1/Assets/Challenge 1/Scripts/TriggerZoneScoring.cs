/*
* Chris Smith
* Assignment 2
* Increments score counter upon triggering zone.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneScoring : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
