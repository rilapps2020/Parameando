using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToPlant : MonoBehaviour {
	public GameObject objetivo;
	public GameObject other;

	void npcToPlant()
	{
		other.gameObject.GetComponent<NavMeshController>().objetivo = objetivo.GetComponent<Transform>();
	}
}
