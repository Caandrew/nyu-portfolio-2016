using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class VoiceRecognitionManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	internal void TestCall()
	{
		Debug.Log ("This is here in console");
	}
}


#if UNITY_EDITOR
[CustomEditor(typeof(VoiceRecognitionManager))]
public class VoiceRecognitionManagerEditor : Editor
{
	VoiceRecognitionManager _target;

	void OnEnable()
	{
		_target = (VoiceRecognitionManager)target;
	}

	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		//Use this section to make calls into you script from editor mode
		if (GUILayout.Button ("Test Button")) 
		{
			_target.TestCall ();
		}
	}
}
#endif