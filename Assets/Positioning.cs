using UnityEngine;
using System.Collections;

public class Positioning : MonoBehaviour {
	public GameObject cart;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position;
		Vector3 temp = new Vector3 (player.transform.position.x, player.transform.position.y + 1, player.transform.position.z-1);
		this.transform.position = temp;

	}
}
