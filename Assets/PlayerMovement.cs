using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidbody;

	// Use this for initialization
	//void Start () {
 //       rigidbody.AddForce(0, 200, 500);
	//}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody.AddForce(0, 0, 2000 * Time.deltaTime);
		
	}
}
