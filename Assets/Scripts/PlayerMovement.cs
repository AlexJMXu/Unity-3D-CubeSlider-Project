using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewayForce = 100f;

	private bool moveRight = false;
	private bool moveLeft = false;

	void Update() {
		if (Input.GetKey("d")) moveRight = true;
		else moveRight = false;

		if (Input.GetKey("a")) moveLeft = true;
		else moveLeft = false;

	}

	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

		if (moveRight) rb.AddForce(sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
		if (moveLeft) rb.AddForce(-sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
	}
}
