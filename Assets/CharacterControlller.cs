﻿using UnityEngine;
using System.Collections;

public class CharacterControlller : Player {

	public float speed = 2.0F;
	public float intensity = 20.0F;
	public float bulletSpeed = 10.0F;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().freezeRotation = true;
		life = startLife;
	
	}

	// Update is called once per frame
	void Update () {

		float horizontalMove = Input.GetAxis ("Horizontal") * speed;
		float verticalMove = Input.GetAxis ("Vertical") * speed;
		Rigidbody rb = GetComponent<Rigidbody> ();

		if (Input.GetKeyDown (KeyCode.Space)) {
			//rb.AddForce (new Vector3 (0, 1, 0) * intensity, ForceMode.Impulse);
			GameObject shot = Instantiate(Resources.Load("ShotPrefab")) as GameObject;
			shot.transform.position = transform.position + transform.forward * 2;

			Rigidbody shotRb = shot.GetComponent<Rigidbody> ();
			shotRb.AddForce (transform.forward * bulletSpeed, ForceMode.Impulse);
			shotRb.freezeRotation = true;
		}

		horizontalMove *= speed * Time.deltaTime;
		verticalMove *= speed * Time.deltaTime;
		transform.Translate (horizontalMove, 0, verticalMove);
	}

}
