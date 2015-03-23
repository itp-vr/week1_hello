using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour {
	public float range = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//create offset that's between -range and range.
		float x = Random.Range(-range, range);
		float y = Random.Range(-range, range);
		float z = Random.Range(-range, range);
		transform.position += new Vector3(x,y,z);
	}
}
