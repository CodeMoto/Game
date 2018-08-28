using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
    public float forwardForce;
    public float sideWays;
	public bool left = false;
	public bool right = false;
	// Use this for initialization

	// Update is called once per frame
	public void onPressRight(){
		Debug.Log ("pressedright");
		right = true;
	}

	public void onReleaseRight()
	{
		Debug.Log ("releasedRight");
		right = false;
	}


	public void onPressLeft(){
		Debug.Log ("pressedLeft");
		left = true;
	}

	public void onReleaseLeft()
	{
		Debug.Log ("releasedLeft");
		left = false;
	}

	void Update () {
        
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (right == true) {
			rb.AddForce(sideWays * Time.deltaTime, 0, 0);
		}

		if (left == true) {
			rb.AddForce(-sideWays * Time.deltaTime, 0, 0);
		}

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWays * Time.deltaTime, 0, 0);
        }
		if (Input.GetKey ("a")) {
			rb.AddForce (-sideWays * Time.deltaTime, 0, 0);
		}
		if (rb.position.y <= -1f) {
			FindObjectOfType<GameManagerr> ().EndGame();
		}
		/*
		if (Input.touchCount > 0) {

			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				if (Input.GetTouch (0).position.x > 1000f) {
					rb.AddForce(sideWays * Time.deltaTime, 0, 0);
				}
				if (Input.GetTouch (0).position.x < 1000f) {
					rb.AddForce(-sideWays * Time.deltaTime, 0, 0);
				}
			}
			if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				if (Input.GetTouch (0).position.x > 1000f) {
					rb.AddForce(sideWays * Time.deltaTime, 0, 0);
				}
				if (Input.GetTouch (0).position.x < 1000f) {
					rb.AddForce(-sideWays * Time.deltaTime, 0, 0);
				}
			}
			if (Input.GetTouch (0).phase == TouchPhase.Ended) {
			}

		}*/
	}
}
