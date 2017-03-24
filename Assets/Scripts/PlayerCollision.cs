using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	private GameManager gameManager; 

	void Start() {
		gameManager = GameManager.instance;
	}

	void OnCollisionEnter(Collision colInfo) {
		if (colInfo.collider.CompareTag("Obstacle")) {
			movement.enabled = false;
			gameManager.EndGame();
		}
	}
}
