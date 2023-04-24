using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goWithMama : MonoBehaviour
{
    public Transform theDest;



    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("chickenChild").transform;
    }
}










