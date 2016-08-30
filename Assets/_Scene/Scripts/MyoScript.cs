using UnityEngine;
using System.Collections;
using Pose = Thalmic.Myo.Pose;

public class MyoScript : MonoBehaviour {
	public int speed;

	public Rigidbody rb;

	public ThalmicMyo myo;

	private Pose lastPose = Pose.Unknown;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (myo.pose != lastPose) {
			lastPose = myo.pose;
			if (myo.pose == Pose.WaveIn)
			{
				Vector3 push = new Vector3 (0, 0, 1 * Time.deltaTime);
				transform.Rotate(push * speed);
				//transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
			} 
			if (myo.pose == Pose.WaveOut) {
				Vector3 push = new Vector3 (1 * Time.deltaTime, 0, 0);
				transform.Rotate(push * speed);
			}
				
			if (myo.pose == Pose.FingersSpread) 
			{
				Vector3 push = new Vector3 (-1, 0, 0);
				rb.AddForce(push * speed);
			}
					
			if (myo.pose == Pose.Fist) 
			{
				Vector3 push = new Vector3 (1, 0, 0);
				rb.AddForce(push * speed);
			}

				
		}
	
	}
}
