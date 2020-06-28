using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAsset : MonoBehaviour {
	public Material Vol100;
	public Material Vol75;
	public Material Vol50;
	public Material Vol25;
	public Material Vol0;

	
	void Start()
	{
		SetMaterial();
	}
	

	public void SetMaterial()
	{
		int soundState = PlayerPrefs.GetInt("Sound");
		Debug.Log("Insertando material en cubo");
		if (soundState == 0)
		{
			GetComponent<Renderer>().material = Vol0;
		}
		else if (soundState == 25)
		{
			GetComponent<Renderer>().material = Vol25;
		}

		else if (soundState == 50)
		{
			GetComponent<Renderer>().material = Vol50;
		}

		else if (soundState == 75)
		{
			GetComponent<Renderer>().material = Vol75;
		}

		else if (soundState == 100)
		{
			GetComponent<Renderer>().material = Vol100;
		}
	}

	public void SetSoundVol()
	{
		int soundState = PlayerPrefs.GetInt("Sound");
		if(soundState == 100)
		{
			PlayerPrefs.SetInt("Sound", 0);
		}
		else
		{
			PlayerPrefs.SetInt("Sound", soundState += 25);
		}
		SetMaterial();
	}

}
