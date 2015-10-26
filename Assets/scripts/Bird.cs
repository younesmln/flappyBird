using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	float speed = 15;
	float force = 600;

	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * this.speed;
	}

	void LateUpdate () {
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * this.force);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Application.LoadLevel(Application.loadedLevel);
	}
}
