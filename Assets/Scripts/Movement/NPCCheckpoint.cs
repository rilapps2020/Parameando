using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCheckpoint : MonoBehaviour {

	public Transform siguienteNodo;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "NPC")
		{
			other.gameObject.GetComponent<NavMeshController>().objetivo = siguienteNodo;
		}
	}

}
