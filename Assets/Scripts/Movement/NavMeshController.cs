using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

	public Transform objetivo;
	public float tiempo_descanso;
	private NavMeshAgent NPC;
	private Animator anim;


	private Boolean isWalking;
	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
		NPC = GetComponent<NavMeshAgent>();
		anim.SetFloat("Velx", 0f);
		anim.SetFloat("Vely", 1.0f);
		isWalking = true;
	}

	// Update is called once per frame
	void Update()
	{

		NPC.SetDestination(objetivo.position);
		if (isWalking)
		{
			//print("Despertar");
			GetComponent<NavMeshAgent>().speed = 1.3f;
			anim.SetBool("Sleep", false);


		}
		else
		{
			//print("Dormir");
			GetComponent<NavMeshAgent>().speed = 0f;
			anim.SetBool("Sleep", true);
		}

	}

	IEnumerator Temporizador()
	{

		yield return new WaitForSeconds(tiempo_descanso);
		isWalking = !isWalking;

	}
}
