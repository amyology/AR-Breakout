using UnityEngine;
using System.Collections;

public class Disappear : MonoBehaviour {

	public GameObject squares;

	void OnCollisionEnter2D (Collision2D other) {
		Destroy (gameObject.GetComponent<BoxCollider2D>());
		squares.SetActive (true);
	}
}
