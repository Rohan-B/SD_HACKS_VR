using UnityEngine;
using System.Collections;

public class Height : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 
		Vector3 temp = new Vector3 (this.transform.position.x, 1, this.transform.position.z);
		this.transform.position = temp;
	
	}
}
