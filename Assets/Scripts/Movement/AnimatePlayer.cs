using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	public GameObject characterCam;
	private Boolean stateWalking;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		stateWalking = characterCam.GetComponent<Autowalk>().isWalking;
		if (stateWalking)
		{
			anim.SetFloat("IsWalking", 1);
		}
		else
		{
			anim.SetFloat("IsWalking", 0);
		}
	}
}
