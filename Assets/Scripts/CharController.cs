using UnityEngine;
using System.Collections;

public class CharController : Player {

	public float speed = 2.0F;
	public float jumpForce = 10.0F;
	public float bulletSpeed = 10.0F;
	public string horizontalController = "Horizontal";
	public string verticalController = "Vertical";
	public string fireButton = "Fire1";


	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().freezeRotation = true;
		life = startLife;
	
	}

	// Update is called once per frame
	void Update () {

		float horizontalMove = Input.GetAxis (horizontalController) * speed;
		float verticalMove = Input.GetAxis (verticalController) * speed;

		if (Input.GetButtonDown(fireButton)) {
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
