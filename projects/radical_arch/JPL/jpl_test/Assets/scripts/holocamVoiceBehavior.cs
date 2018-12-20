using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holocamVoiceBehavior : MonoBehaviour {
	public GameObject particleCube;
	public GameObject aeroParticleCube;
	public GameObject aeroObject;
	// Use this for initialization
	void Start () {
		aeroParticleCube.SetActive (false);
		aeroObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//Replace with voice command	
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			//enable creaftComponant
			//move particleCube to position two
			particleCube.SetActive (false);
			aeroObject.SetActive (true);
			aeroParticleCube.SetActive (true);
		} else if (Input.GetKeyDown(KeyCode.Alpha1)) {
			particleCube.SetActive (true);
			aeroObject.SetActive (false);
			aeroParticleCube.SetActive (false);	
		}
	}
}
