using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamFollow : MonoBehaviour
{
	private Transform target;           
	public float smoothing = 5f;
	public float smoothingRot = 1f;
	public GameObject [] targets;
	Vector3 offset;                     


	void FixedUpdate ()
	{targets = GameObject.FindGameObjectsWithTag("Need");
		if (targets[1].activeInHierarchy == true) { 

			Vector3 targetPos = targets[1].transform.position;
			transform.position = Vector3.Lerp (transform.position, targetPos, smoothing * Time.deltaTime);


			Quaternion targetRot = targets[1].transform.rotation;
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRot, smoothingRot * Time.deltaTime);


		} 

	}
}