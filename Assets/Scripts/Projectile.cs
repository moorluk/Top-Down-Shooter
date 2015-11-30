using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	float speed;

	// Use this for initialization
	public void SetSpeed( float spd) {
		speed = spd;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
