﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour {

	/*  Se quita este void start el 28/06/2020
	void Start()
	{
		int state = PlayerPrefs.GetInt("State");
		
		if (state == 0)
		{
			Debug.Log("Primera vez");
		}

		if (state == 1)
		{
			Debug.Log("Modo normal");
			ChangeSceneTo("MainMenu");
		}

		if (state == 2)
		{
			Debug.Log("Modo VR");
			ChangeSceneTo("MainMenu");
		}
	}

	*/
	public void ChangeSceneTo(string sceneName) ///State 0 = Primera vez, State 1 = Modo normal, State 2 = Modo VR
	{
		SceneManager.LoadScene(sceneName);
	}

	public void SetScene(int usrState)
	{
		PlayerPrefs.SetInt("State", usrState);
	}
}
