using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	Vector3 velocity;
	Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}

	public void Move( Vector3 vel) {
		velocity = vel;
	}

	public void LookAt(Vector3 pos) {
		Vector3 look = new Vector3 (pos.x, transform.position.y, pos.z);
		transform.LookAt (look);
	}

	// Update is called once per frame
	void FixedUpdate () {
		rigidBody.MovePosition (transform.position + velocity * Time.fixedDeltaTime); 
	}
}
