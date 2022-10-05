using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //These variables change movement speed
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float moveSpeed = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        Instructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void Instructions() {
        //Logs out instructions for the player at beginning of game
        Debug.Log("Welcome to the game");
        Debug.Log("Your goal is to avoid obstacles/walls and reach the end of the course");
        Debug.Log("Move your player with W,A,S,D or arrow keys");
    }

    void PlayerMovement() {
        //Assigning horizontal & vertical input to variables
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //Move the player object
        transform.Translate(xValue,0,zValue);
    }
}
