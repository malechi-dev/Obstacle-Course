using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateXAngle = 0f;
    [SerializeField] float rotateYAngle = 0f;
    [SerializeField] float rotateZAngle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateXAngle, rotateYAngle, rotateZAngle);
    }
}
