using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigid;

    //Create variable for time dropping object needs to wait
    [SerializeField] float dropWaitTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        render.enabled = false;

        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        //if time goes over wait time, drop object using gravity settings
        if (Time.time > dropWaitTime) {
            render.enabled = true;
            rigid.useGravity = true;
        }
    }
}
