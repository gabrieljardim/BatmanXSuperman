using UnityEngine;
using System.Collections;

public class CharacterControlller : MonoBehaviour {

	public float speed = 2.0F;
	public float intensity = 20.0F;

	// Use this for initialization
	void Start () {


		GetComponent<Rigidbody> ().freezeRotation = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		float horizontalMove = Input.GetAxis ("Horizontal") * speed;
		float verticalMove = Input.GetAxis ("Vertical") * speed;
		Rigidbody rb = GetComponent<Rigidbody> ();

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector3 (0, 1, 0) * intensity, ForceMode.Impulse);
		}

		horizontalMove *= speed * Time.deltaTime;
		verticalMove *= speed * Time.deltaTime;
		transform.Translate (horizontalMove, 0, verticalMove);
	
	}
}
