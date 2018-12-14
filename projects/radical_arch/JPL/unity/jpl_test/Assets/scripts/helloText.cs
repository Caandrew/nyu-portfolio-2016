using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class helloText : MonoBehaviour {
	public Text winText;
	// Use this for initialization
	void Start () {
		winText.text = "";
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			winText.text = "Hello!";
		} else if(Input.GetKeyDown(KeyCode.Alpha1)) {
			winText.text= "";
		}
	}
}
