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
        movePlayer();
        faceMouse();
    }

    private void movePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;

        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement);
    }

    private void faceMouse() {

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);

        //Vector2 mousePos;
        //Vector3 screenPos;

        //mousePos = Input.mousePosition;
        //screenPos = camera.main.ScreenToWorldPoint(Vector3(mousePos.x, mousePos.y, transform.position.z - camera.main.transform.position.z));

        //this.transform.rotation.eulerAngles.z = Mathf.Atan2((screenPos.y - transform.position.y), (screenPos.x - transform.position.x)) * Mathf.Rad2Deg;

    }
}
