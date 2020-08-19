﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {

	public float velocidadMovimiento = 5.0f;
	public float velocidadRotacion = 200.0f;
	private Animator anim;
	public float x, y;
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis("Horizontal");
		y = Input.GetAxis("Vertical");

		transform.Rotate(0, x*Time.deltaTime * velocidadRotacion, 0);
		transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
		

		anim.SetFloat("Velx", x);
		anim.SetFloat("Vely", y);
		
	}
}
