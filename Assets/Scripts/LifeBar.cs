using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour {

	private Camera cam;
	public Player player;
	private Image img;

	// Use this for initialization
	void Start () {

		player = GetComponentInParent<Player> ();
		img = GetComponent<Image>();

	}

	// Update is called once per frame
	void Update () {
		img.fillAmount = (float)player.life / (float)player.startLife;
	
	}
}
