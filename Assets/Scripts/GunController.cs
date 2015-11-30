﻿using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	public Transform weaponHold;
	public Gun startingGun;
	Gun equippedGun;

	// Use this for initialization
	void Start () {
		if (startingGun != null) {
			EquipGun(startingGun);
		}
	}
	
	void EquipGun(Gun gun) {
		if (equippedGun != null) {
			Destroy(equippedGun);
		}

		equippedGun = Instantiate (gun, weaponHold.position, weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;
	}

	public void Shoot() {
		if (equippedGun != null) {
			equippedGun.Shoot();
		}
	}
}
