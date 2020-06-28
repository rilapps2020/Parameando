using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour {

	public void ChangeMenu(GameObject nextMenu)
	{
		Instantiate(nextMenu);
	}
	public void DestroyMenu(GameObject menu)
	{
		Destroy(menu);
	}
}
