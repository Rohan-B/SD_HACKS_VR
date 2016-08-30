using UnityEngine;
using System.Collections;

public class Setmovement : MonoBehaviour {
	public float speed;
	public int x = 0;
	public GameObject cart;
	public GameObject player;



	/*// Use this for initialization
	void Start () {
		Debug.Log (x);
		if (x == 0) {
			StartCoroutine (methodfirst (player));
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (x == 0) {
//			StartCoroutine (methodfirst ());
		}

		if (x == 1) {
			StartCoroutine (method2nd ());
		}

		if (x == 2) {
			//StartCoroutine (method3rd ());
		}

		if (x == 3) {
			//StartCoroutine (method4th ());
		}

	}

	IEnumerator methodfirst(Collider car) {
		
		Vector3 start = cart.transform.position;
		Vector3 end = new Vector3 (cart.transform.position.x, cart.transform.position.y, cart.transform.position.z + 100);
		
		for (float i = 0; i < 20; i+=Time.deltaTime) {
			
			car.GetComponent<cart>().cart1.transform.position = Vector3.Lerp (start, end, i/20);
			yield return null;	
		}
		x = 1;
	}

	IEnumerator method2nd() {
		
		Vector3 start = cart.transform.position;
		Vector3 end = new Vector3 (cart.transform.position.x, cart.transform.position.y, cart.transform.position.z - 100);
		
		for (float i = 0; i < 20; i+=Time.deltaTime) {
			
			cart.transform.position = Vector3.Lerp (start, end, i);
			yield return null;	
		}
		x = 2;
	}*/

}