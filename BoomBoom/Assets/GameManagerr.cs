using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerr : MonoBehaviour {

	public GameObject over;
	bool gameOver1 = false;
	public float restartDelay = 1f;
	public void EndGame()
	{
		if (gameOver1 == false) {
			gameOver1 = true;
			over.SetActive (true);
		}
	}
		
	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void Menu()
	{
		SceneManager.LoadScene ("menu");
	}
}
