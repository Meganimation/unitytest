using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelScript : MonoBehaviour {
//Attach this script to the GameManager and use it to load the other scene

	public string levelToLoad;

	public void ApplicationLoadLevel(){
		Application.LoadLevel (levelToLoad);
	}
}
