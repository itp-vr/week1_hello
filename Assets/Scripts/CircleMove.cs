using UnityEngine;
using System.Collections;

public class CircleMove : MonoBehaviour {

	public Transform origin;
	public float speed = 1f;
	public float ySpeed = 10f;
	private float dist;
	private float initY;
	// Use this for initialization
	void Start () {
		dist = Vector3.Distance(origin.position, transform.position);
		initY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Sin (Time.time*speed)*dist;
		float y = Mathf.Sin(Time.time*ySpeed);
		float z = Mathf.Cos (Time.time*speed)*dist;
		transform.localPosition = new Vector3(x,y,z);
	}
}
