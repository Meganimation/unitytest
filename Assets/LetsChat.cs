using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LetsChat : MonoBehaviour
{
    GameObject plyr;

 
    void Start()
    {
        plyr = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, plyr.transform.position);
        // dist variable to calculate the 3D distance (Vector3) between the Zombie and Player.

        if (dist <= 5.0f)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Canvas canvas = FindObjectOfType<Canvas>();
                if (canvas != null)
                {
                    Transform userInputTransform = canvas.transform.Find("UserInput");
                    if (userInputTransform != null)
                    {
                        GameObject userInput = userInputTransform.gameObject;
                        userInput.SetActive(true);

                        TMP_InputField tmpInputField = userInput.GetComponent<TMP_InputField>();
                        if (tmpInputField != null)
                        {
                            tmpInputField.Select();
                            tmpInputField.ActivateInputField();

                            // Additional checks
                            if (!tmpInputField.isFocused)
                            {
                                Debug.Log("TMP_InputField not focused");
                                // Add debugging or alternative actions here
                            }
                        }
                    }
                }
            }
        }
    }
}
