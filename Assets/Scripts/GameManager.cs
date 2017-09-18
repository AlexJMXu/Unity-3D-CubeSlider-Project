using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	public static GameManager instance;

	private float restartDelay = 2f;

	private bool gameHasEnded = false;

	public GameObject completeLevelUI;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	public void CompleteLevel() {
		completeLevelUI.SetActive(true);
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


	void myFunction() {
		int variableOne = 1;

		return VariableOne;
	}
}
