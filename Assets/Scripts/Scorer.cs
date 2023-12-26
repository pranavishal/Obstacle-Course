using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Plane" && collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("Your score is now " + score);
        }

    }
}
