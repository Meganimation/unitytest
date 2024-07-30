using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour {
	
    Transform m_Camera;

	void Start()
	{
        m_Camera = GameObject.FindWithTag("MainCamera").transform;
	}
	void Update()
	{
		transform.LookAt (new Vector3(m_Camera.position.x,transform.position.y,m_Camera.position.z));
	}
}
