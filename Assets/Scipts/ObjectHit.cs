using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //Method which changes the color to red when walls are collided with
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
