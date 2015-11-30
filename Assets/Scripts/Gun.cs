using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShot = 100f;
	public float muzzleSpeed = 100f;

	float nextShotTime;

	// Use this for initialization
	public void Shoot() {

		if (Time.time > nextShotTime) {
			nextShotTime = Time.time + msBetweenShot/1000;
			Projectile newProj = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProj.SetSpeed(muzzleSpeed);
		}

	}
}
