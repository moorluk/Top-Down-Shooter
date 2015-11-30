using UnityEngine;
using System.Collections;

[RequireComponent (typeof (PlayerController))]
[RequireComponent (typeof (GunController))]
public class Player : MonoBehaviour {
	PlayerController controller;
	GunController gunController;
	Camera viewCam;

	public float moveSpeed = 5f; 

	// Use this for initialization
	void Start () {
		controller = GetComponent<PlayerController> ();
		gunController = GetComponent<GunController> ();
		viewCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		// Movement Input
		Vector3 moveVelocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		moveVelocity = moveVelocity.normalized * moveSpeed;
		controller.Move (moveVelocity);

		// Look Input
		Ray ray = viewCam.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector3.up, Vector3.zero);
		float dist;

		if ( plane.Raycast(ray, out dist)) {
			Vector3 look = ray.GetPoint(dist);
			controller.LookAt(look);
		}

		// Weapon Input
		if (Input.GetMouseButton (0)) {
			gunController.Shoot();
		}
	}
}
