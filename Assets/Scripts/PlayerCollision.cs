using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement; 

	void OnCollisionEnter(Collision colInfo) {
		if (colInfo.collider.CompareTag("Obstacle")) {
			movement.enabled = false;
		}
	}
}
