using UnityEngine;
using System.Collections;

public class forward45 : MonoBehaviour {
	public GameObject player;
	public GameObject cart;
	public GameObject checkpoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	
	void OnTriggerEnter(Collider car) {
		StartCoroutine (methodfirst (car));
		Debug.Log ("hi!!!!!!!!!!!!!!!!");
		
	}
	
	IEnumerator methodfirst(Collider car) {
		Debug.Log ("HELP PLS");
		Vector3 start = car.transform.position;
		Vector3 end = checkpoint.transform.position;
		
		for (float i = 0; i < 20.0f; i+=Time.deltaTime) {
			
			car.transform.position = Vector3.Lerp (start, end, i/20);
			yield return null;		
		}
		yield return null;
		

		car.GetComponent<cart> ().cart1.transform.Rotate (0, 90, 0);
		
	}
	
}


