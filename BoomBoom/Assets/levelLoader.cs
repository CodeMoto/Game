using UnityEngine.SceneManagement;
using UnityEngine;

public class levelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void loadLevel_1(){
		SceneManager.LoadScene ("Level1");
	}
	public void loadMainMenu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void Exit()
	{
		Application.Quit();
		Debug.Log ("Exit");
	}
}
