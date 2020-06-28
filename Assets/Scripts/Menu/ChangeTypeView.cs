using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTypeView : MonoBehaviour {

	// Use this for initialization
	public void ChangeView(int type)
	{
		PlayerPrefs.SetInt("State", type);
	}
}
