using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;

    MeshRenderer theRenderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        theRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        theRenderer.enabled = false;
        rb.useGravity = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time >= waitTime)
        {
            theRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
