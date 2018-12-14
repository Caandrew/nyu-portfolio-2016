using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aeroSaysHello : MonoBehaviour {

	public AudioSource helloFromAero;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			helloFromAero.Play ();
		}
	}
}
