using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.gameObject.tag != "Stop")
            {
                this.GetComponent<MeshRenderer>().material.color = Color.yellow;
                this.gameObject.tag = "Hit";
            }
            Destroy(other.gameObject);
        }
        
        
    }
}
