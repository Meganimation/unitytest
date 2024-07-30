using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {
//Attach this script to the Zombie Prefab
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Rock") {
            ScoreCount.gscore += 1; //add score
			Debug.Log ("Zombie Killed");	
		}
	}
}
