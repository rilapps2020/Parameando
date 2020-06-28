using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAsset : MonoBehaviour {

	public Material JoyStick;
	public Material KeyBoard;

	// Use this for initialization
	void Start () {
		setMaterial();
	}
	
	// Update is called once per frame
	public void setMaterial()
	{
		int stateController = PlayerPrefs.GetInt("Controller");
		if(stateController == 0)
		{
			GetComponent<Renderer>().material = JoyStick;
		}

		else if (stateController == 1)
		{
			GetComponent<Renderer>().material = KeyBoard;
		}
	}

	public void setSoundState()
	{
		int stateController = PlayerPrefs.GetInt("Controller");
		if(stateController == 1)
		{
			PlayerPrefs.SetInt("Controller", 0);
		}
		else
		{
			PlayerPrefs.SetInt("Controller", stateController += 1);
		}
		setMaterial();
	}
}
