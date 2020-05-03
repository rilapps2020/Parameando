using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour {

	public GameObject camara;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation = Quaternion.Euler(0, camara.transform.eulerAngles.y, 0); //Fixed Angle
	}
}
