using UnityEngine;
using System.Collections;

public class RockScript : MonoBehaviour {
//attach this script to the bullet Prefab

	float lifespan = 3.0f; //how long the bullet will stay in the game scene

	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0) {
			Explode();
		}
	}

	//Bullet will be directly destroyed if it collides with Zombie
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Zombie") {
			Destroy(gameObject);			
		}
	}

	//Explode function to destroy bullet
	void Explode() {
		Destroy(gameObject);
	}
}
