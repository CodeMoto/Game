using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFollow : MonoBehaviour {

	public Transform light;
	public Transform player;
	
	// Update is called once per frame
	void Update () {
		light.position = player.position;
	}
}
