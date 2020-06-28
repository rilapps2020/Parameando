using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTest : MonoBehaviour {

	public void Red()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}

	public void Blue()
	{
		GetComponent<Renderer>().material.color = Color.blue;
	}

	public void Black()
	{
		GetComponent<Renderer>().material.color = Color.black;
	}

	public void Green()
	{
		GetComponent<Renderer>().material.color = Color.green;
	}

	public void Restart(Material texture3D)
	{
		GetComponent<Renderer>().material = texture3D;
	}
}
