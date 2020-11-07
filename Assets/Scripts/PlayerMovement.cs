using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D rb2d;



    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;

        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        faceMouse();
        rb2d.AddForce(movement);
       

   
    }

    void faceMouse()
    {

    }
}
