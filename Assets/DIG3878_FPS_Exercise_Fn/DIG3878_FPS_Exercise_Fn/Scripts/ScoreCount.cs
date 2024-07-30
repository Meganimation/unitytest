using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //add this line

public class ScoreCount : MonoBehaviour {
// create ScriptManager and attach this script

	public static int gscore = 0;
    public GameObject BGAudio;
    public GameObject YouWinAudio;

	public Text scoreText;
	public GameObject youWin;

	void Update(){
		scoreText.text = "Score: " + gscore;
		if (gscore >= 5) {
			youWin.SetActive (true);
            BGAudio.SetActive(false);
            YouWinAudio.SetActive(true);
		}
	}
}
