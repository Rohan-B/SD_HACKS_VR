using UnityEngine;
using System.Collections;

public class FirstTurn : MonoBehaviour {

	public GameObject cart;
	public GameObject player;
	public GameObject checkpoint;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider car) {
		StartCoroutine (method1 (car));
		Debug.Log ("hi");

	}


	IEnumerator method1 (Collider car) {
		Quaternion start = car.GetComponent<cart>().cart1.transform.rotation;
		Vector3 cart_face = new Vector3 (cart.transform.position.x - 1, cart.transform.position.y, cart.transform.position.z);
		cart.transform.LookAt (cart_face);
		Quaternion end = cart.transform.rotation;
		Debug.Log ("test1");
		for (float i = 0; i < 2.0f; i+= Time.deltaTime) {
			car.GetComponent<cart>().cart1.transform.rotation = Quaternion.Lerp(start,end,i/2);
			Debug.Log (cart.transform.rotation);
			yield return null;
		} 

		Vector3 start11 = car.transform.position;
		Vector3 end11 = checkpoint.transform.position;//new Vector3 (car.transform.position.x + 14, car.transform.position.y, car.transform.position.z);
		for (float i = 0; i < 2.0F; i+=Time.deltaTime) {
			
			car.transform.position = Vector3.Lerp (start11, end11, i/2);
			yield return null;	
		}


		car.GetComponent<cart> ().cart1.transform.Rotate (0, 90, 0);

		/*Vector3 forward1 = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z + 90);
		Vector3 fwds1 = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);
		for (float i = 0; i < 20.0f; i+= Time.deltaTime) {
			player.transform.position = Vector3.Lerp(fwds1,forward1, i/20);
		}
		yield return null;
	*/	
	}



}

