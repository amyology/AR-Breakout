using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	public GameController controller;

	void OnCollisionEnter2D(Collision2D other) {
		Destroy (other.gameObject);
		controller.isActive = false;
	}
}
