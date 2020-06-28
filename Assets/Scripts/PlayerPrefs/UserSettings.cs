using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSettings : MonoBehaviour {
	/*
		Prefabs para el usuario
		ULTIMA MODIFICACION: 27/06/2020
		State : Define el estado del juego (Modo VR 2, Modo Plano 1, Modo inicial 0) | type: int | **EN DESUSO**
		Sound : Define el volumen del juego | Valores estandar para VR(0,25,50,75,100) | type: int | En uso desde el 27/06/2020
		Controller : Define el tipo de control a usar | Valores estandar para VR (Control JoyStick : 0 , Control Teclado : 1 ) | En uso desde el 27/06/2020

	*/
	public void SetPrefabInt(string prefabName, int value)
	{
		PlayerPrefs.SetInt(prefabName, value);
	}

	public void GetPrefabInt(string prefabName)
	{
		PlayerPrefs.GetInt(prefabName);
	}

	public void SetPrefabString(string prefabName, string value)
	{
		PlayerPrefs.SetString(prefabName, value);
	}

	public void GetPrefabString(string prefabName)
	{
		PlayerPrefs.GetString(prefabName);
	}

	public void SetPrefabFloat(string prefabName, float value)
	{
		PlayerPrefs.SetFloat(prefabName, value);
	}

	public void GetPrefabFloat(string prefabName)
	{
		PlayerPrefs.GetFloat(prefabName);
	}
}
