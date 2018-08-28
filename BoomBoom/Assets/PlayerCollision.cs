using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement pm;
	public Rigidbody rb;
	public Animator box;
	Transform a;
	void OnCollisionEnter(Collision col)
    {
		if (col.collider.tag == "obstacle") {
			pm.enabled = false;
			FindObjectOfType<GameManagerr>().EndGame(); 
		}
    }
}
