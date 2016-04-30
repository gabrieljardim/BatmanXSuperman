using UnityEngine;
using System.Collections;

public class CharacterControlller : MonoBehaviour {

	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float horizontalMove = Input.GetAxis ("Horizontal") * speed;
		float verticalMove = Input.GetAxis ("Vertical") * speed;

		horizontalMove *= speed * Time.deltaTime;
		verticalMove *= speed * Time.deltaTime;
		transform.Translate (horizontalMove, 0, verticalMove);
	
	}
}
