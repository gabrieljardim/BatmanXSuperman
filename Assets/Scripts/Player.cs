using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int life;
	public int startLife = 100;
	public int basicDamage = 10;

	public void decreaseLife()
	{
		life -= basicDamage;
		if (life <= 0)
			Destroy (gameObject);
	}
}
