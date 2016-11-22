using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject P;
	public GameObject L;
	public GameObject A;
	public GameObject Y;
	public GameObject text;
	public bool isActive;
	public Rigidbody2D ballRb;
	public GameObject paddle;
	public Rigidbody2D paddleRb;
	public GameObject ballPrefab;
	GameObject newBall;
	int speed = 30;
	Vector2 startPosition;
	bool gameOver;

	void Start () {
		isActive = false;
		gameOver = false;
		startPosition = paddle.transform.position;
	}

	void Update () {
		if (P.activeSelf == true && L.activeSelf == true && A.activeSelf == true && Y.activeSelf == true) {
			EndGame ();
		}

		paddle.transform.position = new Vector2 (Mathf.Clamp(paddle.transform.position.x, -26.1f, 26.1f), paddle.transform.position.y);
	}

	public void moveLeft () {
		Move (-speed);
	}

	public void moveRight () {
		Move (speed);
	}

	void Move (int speed){
		paddleRb.velocity = new Vector2 (speed, 0);
	}

	public void Stop () {
		paddleRb.velocity = new Vector2 (0, 0);
	}

	public void LaunchBall () {
		if (isActive == false && gameOver == false) {
			paddle.transform.position = startPosition;
			GameObject newBall = Instantiate (ballPrefab) as GameObject;
			Rigidbody2D newBallRb = newBall.GetComponent<Rigidbody2D> ();
			newBallRb.velocity = new Vector2 (0, speed);
			isActive = true;
		}
	}

	public void Exit () {
		Application.Quit ();
	}

	void EndGame () {
//		text.SetActive (true);
		paddle.SetActive (false);
		gameOver = true;
	}

	public void Restart () {
		SceneManager.LoadScene ("Main");
	}
}
