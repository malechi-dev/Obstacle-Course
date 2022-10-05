using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //initialize the hits variable
    int hits = 0;

    //increase hits every time on collision and print to console
    private void OnCollisionEnter(Collision other) {
            if (other.gameObject.tag != "Hit"){
                hits ++;
                Debug.Log("You've bumped into me this many times: " + hits);
            }    
        }
}
