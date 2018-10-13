using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour {

	public float force = 1000;

	void Start (){
	}
	void OnTriggerEnter(Collider other){
		print (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			other.GetComponent<Rigidbody>().AddForce(transform.up * force, ForceMode.VelocityChange);
		}
	}
}
