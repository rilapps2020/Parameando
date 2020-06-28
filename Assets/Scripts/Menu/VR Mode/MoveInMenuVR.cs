using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInMenuVR : MonoBehaviour {
	public float speed;
	
	//Main Menu
	public GameObject MainMenu;
	public GameObject TargetStartMain;
	public GameObject TargetFinalMain;

	//Options
	private Boolean options = false;
	public GameObject MenuOptions;
	public GameObject TargetStartOptions;
	public GameObject TargetFinalOptions;

	public void ChangerMenu(GameObject oldState)
	{
		if(oldState.tag.Equals("Main_Menu"))
		{
			Debug.Log("Main menu");
			options = true;
		}
	}

	void Update()
	{
		float steps = speed * Time.deltaTime; //Velocidad de movimiento entre menus
		if(options) //Mover para entrar en el menu de opciones
		{
			MainMenu.transform.position = Vector3.MoveTowards(MainMenu.transform.position,
															  TargetFinalMain.transform.position,
															  steps);

			MenuOptions.transform.position = Vector3.MoveTowards(MenuOptions.transform.position,
															  TargetFinalOptions.transform.position,
															  steps);
		}
		else if(options == false) //Regresar al menu principal
		{
			MainMenu.transform.position = Vector3.MoveTowards(MainMenu.transform.position,
															  TargetStartMain.transform.position,
															  steps);

			MenuOptions.transform.position = Vector3.MoveTowards(MenuOptions.transform.position,
															  TargetStartOptions.transform.position,
															  steps);
		}
	}

	public void returnMainMenu()
	{
		options = false;
	}
}
