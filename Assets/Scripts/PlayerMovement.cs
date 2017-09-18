using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewayForce = 100f;

	private bool moveRight = false;
	private bool moveLeft = false;

	private GameManager gameManager;

	private bool canJump = true;

	void Start() {
		gameManager = GameManager.instance;
	}

	void Update() {
		if (Input.GetKey("d")) moveRight = true;
		else moveRight = false;

		if (Input.GetKey("a")) moveLeft = true;
		else moveLeft = false;

		if (Input.GetKeyDown (KeyCode.Space) && canJump == true) {
			Jump ();
			canJump = false;
			Invoke ("ReactivateJump", 1);
		}

	}

	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

		if (moveRight) rb.AddForce(sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
		if (moveLeft) rb.AddForce(-sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
	
		if (rb.position.y < -1f) {
			gameManager.EndGame();
		}
	}

	void Jump() {
		rb.AddForce (0, 7, 0, ForceMode.VelocityChange);
	}

	void ReactivateJump() {
		canJump = true;
	}
}
