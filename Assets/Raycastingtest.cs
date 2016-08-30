using UnityEngine;
using System.Collections;
using Pose = Thalmic.Myo.Pose;
using UnityEngine.UI;

public class Raycastingtest : MonoBehaviour {
	Camera camera;
	public ThalmicMyo myo;
	private Pose lastPose = Pose.Unknown;
	public int y = 1;
	public GameObject crystal;
	public static int scoreval = 100;
	public static int score = 0;
	public GameObject Canvas;
	public GameObject text;
	public GameObject crosshair;
	public float thickness = 2;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("hi11");
		string crystaltag = crystal.tag;
		Ray ray = new Ray (crosshair.transform.position, crosshair.transform.forward);
		//Debug.Log (ray);
		Debug.DrawRay(crosshair.transform.position,crosshair.transform.forward * 1000);
		//Debug.Log (Camera.main.transform.position);
		//Debug.Log ("hi");

		RaycastHit hit;
		if ((Physics.SphereCast (crosshair.transform.position, thickness, crosshair.transform.forward, out hit, Mathf.Infinity))) {
			Debug.Log ("im looking at" + hit.collider.name);
		    if (hit.collider.tag == crystaltag) {
				Debug.Log ("im looking at20000" + hit.collider.name);
				if (myo.pose == Pose.Fist) {
					Debug.Log ("boom bitch");
					Destroy(hit.transform.gameObject);
					AddScore();
				}
			}
		}

		else {
			Debug.Log ("im looking at nothing");
		}
	}

	void AddScore() {
		score += scoreval;
		Text txt = text.GetComponent<UnityEngine.UI.Text>();
		Debug.Log (txt);
		txt.text = "Score : " + score;

	}
}