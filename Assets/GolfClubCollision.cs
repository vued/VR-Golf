using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfClubCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision other) {
		Debug.Log (other.gameObject.tag);
		// how much the character should be knocked back
		var magnitude = 5000;
		// calculate force vector
		var force = transform.position - other.transform.position;
		// normalize force vector to get direction only and trim magnitude
		force.Normalize();
		other.gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
	}
}