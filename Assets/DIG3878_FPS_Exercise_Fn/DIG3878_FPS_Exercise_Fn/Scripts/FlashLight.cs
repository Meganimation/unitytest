using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

    public GameObject flashLight;
    bool flashlightON = false;

	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.F)&&flashlightON==false){
            flashLight.SetActive(true);
            flashlightON = true;
        }else if (Input.GetKeyDown(KeyCode.F) && flashlightON ==true)
        {
            flashLight.SetActive(false);
            flashlightON = false;
        }
	}
}
