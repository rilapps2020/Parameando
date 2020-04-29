using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour {

	public Camera camara;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(camara.transform.position.x, camara.transform.position.y - 1.669f, camara.transform.position.z - 0.3f); //Fixed position
		transform.localRotation = Quaternion.Euler(0, camara.transform.eulerAngles.y, 0); //Fixed Angle
	}
}
