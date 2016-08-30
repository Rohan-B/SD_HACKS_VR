using UnityEngine;
using System.Collections;

public class Raycasting : MonoBehaviour {
	Camera camera;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = camera.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit))
			print ("im looking at" + hit.transform.name);
		else
			print ("im looking at nothing");
	}
}