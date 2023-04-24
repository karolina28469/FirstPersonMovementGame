using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectEggs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    } 
}
