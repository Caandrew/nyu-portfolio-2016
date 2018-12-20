using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textRotator : MonoBehaviour {

		public Transform target;

		void Update()
		{
			Vector3 relativePos = target.position - transform.position;

			// the second argument, upwards, defaults to Vector3.up
		Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.forward);
			transform.rotation = rotation;
		//this should rotate the script
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
		}
	}
