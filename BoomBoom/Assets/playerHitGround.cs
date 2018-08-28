using System.Collections.Generic;
using UnityEngine;

public class playerHitGround : MonoBehaviour {
	public GameObject player, camera;
	// Update is called once per frame
	void OnCollisionEnter(Collision col) {
		//if (col.collider.tag == "Ground") {
		//camera.GetComponent<FollowPlayer>().enabled = true;
		//}
	}
}
