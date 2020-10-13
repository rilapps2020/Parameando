using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CanvasRender : MonoBehaviour
{

	public GameObject canvasPlayer;
	public Text text;
	private bool canvasState = false;


	string filePath;
	string jsonString;

	void Start()
	{

		canvasPlayer.SetActive(canvasState);
		text.text = "Hello world";

		filePath = Application.dataPath + "/Prefabs/NPC/dialog.json";
		jsonString = File.ReadAllText(filePath);
	}

	public void SetCanvasState()
	{
		canvasState = !canvasState;
		canvasPlayer.SetActive(canvasState);
		print("Funciona");
	}

	
	public void SetText()
	{


		text.text = "Hello world";

	}
}
