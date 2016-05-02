using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int life;
	public int startLife = 100;
	public int basicDamage = 10;


	public void OnCollisionEnter(Collision col)
	{
		Debug.Log (col.gameObject.name);

		if (col.gameObject.name == "Shot") {
			life -= basicDamage;
			Debug.Log ("Life amount = " + life);
		} else
			Debug.Log ("Not shot");
	}
}
