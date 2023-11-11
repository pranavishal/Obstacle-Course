using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (this.GetComponent<MeshRenderer>().material.color == Color.yellow)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        } else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        
    }
}
