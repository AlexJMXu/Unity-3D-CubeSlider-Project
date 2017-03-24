using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	public static GameManager instance;

	private float restartDelay = 2f;

	private bool gameHasEnded = false;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	public void EndGame() {
		if (!gameHasEnded) {
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
	}

	private void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
