/*
* Chris Smith
* Assignment 2
* Trigger and display winning textbox
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
