using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {


	public Transform tpLoc;

	void Start(){
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.transform.position = tpLoc.transform.position;
		}
	}
}