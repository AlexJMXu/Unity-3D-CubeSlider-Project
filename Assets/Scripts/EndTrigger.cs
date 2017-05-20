using UnityEngine;

public class EndTrigger : MonoBehaviour {

	private GameManager gameManager;

	void Start() {
		gameManager = GameManager.instance;
	}

	void OnTriggerEnter() {
		gameManager.CompleteLevel();
	}
}
