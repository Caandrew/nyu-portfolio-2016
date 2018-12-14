using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Always use dependency checking for Unity Editor specific functionality. certain platforms error on build if you dont
#if UNITY_EDITOR
using UnityEditor;
#endif

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
			ToggleAeroParticle (true);
		} else if (Input.GetKeyDown(KeyCode.Alpha1)) {
			ToggleAeroParticle (false);
		}
	}
	/// <summary>
	/// Toggles the aero particle.
	/// </summary>
	/// <param name="aeroParticle">If set to <c>true</c> aero particle activates.</param>
	internal void ToggleAeroParticle(bool aeroParticle)
	{
		//enable creaftComponant
		//move particleCube to position two
		particleCube.SetActive (aeroParticle? false:true);
		aeroObject.SetActive (aeroParticle? true:false);
		aeroParticleCube.SetActive (aeroParticle? true:false);
	}

	internal void TestCall()
	{
		Debug.Log ("This is here in console");
	}
}

#if UNITY_EDITOR
[CustomEditor(typeof(holocamVoiceBehavior))]
public class holocamVoiceBehaviorEditor : Editor
{
	holocamVoiceBehavior _target;

	void OnEnable()
	{
		_target = (holocamVoiceBehavior)target;
	}

	public override void OnInspectorGUI ()
	{
		base.OnInspectorGUI ();
		//Use this section to make calls into you script from editor mode
		if (GUILayout.Button ("Test Button")) 
		{
			_target.TestCall ();
		}
		EditorGUI.BeginChangeCheck ();

		Editor;

		if (EditorGUI.EndChangeCheck ())
		{
			serializedObject().ApplyModifiedProperties ();
		}
	}
}
#endif