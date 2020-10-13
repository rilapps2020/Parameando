using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour {

	public void ButtonTests(Boolean state)
    {
        if(state == true)
        {
            UnityEngine.Debug.Log("Hello world");
        }
    }

    
}
