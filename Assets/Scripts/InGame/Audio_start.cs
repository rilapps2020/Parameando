using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_start : MonoBehaviour {
	void startAudio()
	{
		GetComponent<AudioSource>().Play();
	}
}
