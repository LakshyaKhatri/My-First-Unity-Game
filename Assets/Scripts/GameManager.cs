using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject completeLevelUI;

	bool gameEnded = false;
	public float restartDelay = 1f;

	public void EndGame(){
		if (!gameEnded) {
			gameEnded = true;
			Debug.Log("GAME OVER!");
			Invoke ("Restart", restartDelay);
		}
	}

	public void CompleteLevel(){
		completeLevelUI.SetActive (true);
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
