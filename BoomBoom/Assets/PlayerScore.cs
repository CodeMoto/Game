using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	public Transform player;
	public Text score;
	// Use this for initialization
	void Start () {
		score.text = player.position.z.ToString("F0");
	}
	
	// Update is called once per frame
	void Update () {
		score.text = player.position.z.ToString("F0");
	}
}
