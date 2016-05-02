using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {


	public CharController charController;
	private Transform batmanTransform;

	void Start () {
		Collider c1 = GetComponent<Collider> ();
		Collider c2 = GameObject.Find ("InvisibleWall").GetComponent<Collider> ();

		batmanTransform = GameObject.Find ("Batman").GetComponent<Transform> ();
		Physics.IgnoreCollision (c1, c2);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 distance = transform.position - batmanTransform.position;

		if (distance.magnitude > 20) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Superman" || col.gameObject.name == "Batman") {
			charController = col.gameObject.GetComponent<CharController> ();
			charController.decreaseLife ();
		}
		Destroy (gameObject);
	}
		
}
