using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_trap_script : MonoBehaviour {

		public float playerDamage = 10.0f;

		void Start(){
		}

		void OnCollisionEnter(Collision other) {
			if (other.gameObject.tag == "Player") {
				other.gameObject.GetComponent<PlayerHealth>().TakeDamage (playerDamage);
			}
		}
	}