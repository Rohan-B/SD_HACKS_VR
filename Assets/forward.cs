using UnityEngine;
using System.Collections;

public class forward : MonoBehaviour {
	public GameObject cart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider car) {
		StartCoroutine (methodfirst (car));
		Debug.Log ("hi");
		
	}

	IEnumerator methodfirst(Collider car) {
		
		Vector3 start = car.transform.position;
		Vector3 end = new Vector3 (car.transform.position.x, car.transform.position.y, car.transform.position.z + 87);
		
		for (float i = 0; i < 20; i+=Time.deltaTime) {
			
			car.transform.position = Vector3.Lerp (start, end, i/20);
			yield return null;	
		}
		yield return null;
	}
}
