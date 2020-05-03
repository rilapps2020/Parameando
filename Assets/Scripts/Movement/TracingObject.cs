using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracingObject : MonoBehaviour {


	public GameObject TrackCamera;
	private float radians;
	private float degrees;
	private float xPosition;
	private float zPosition;
	private float xfinalPosition;
	private float yfinalPosition;
	private float zfinalPosition;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		degrees = TrackCamera.transform.eulerAngles.y;
		radians = degrees * Mathf.PI / 180;
		xPosition = 0.35f *Mathf.Cos(radians+3.14f); //X position
		zPosition = 0.35f * Mathf.Cos(radians-1.57f); //Z position
		xfinalPosition = xPosition + TrackCamera.transform.position.x  ;

		yfinalPosition = TrackCamera.transform.position.y ;

		zfinalPosition = zPosition + TrackCamera.transform.position.z ;
		transform.position = new Vector3(xfinalPosition, transform.position.y, zfinalPosition);
	}

}
