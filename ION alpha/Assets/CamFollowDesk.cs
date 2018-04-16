using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamFollowDesk : MonoBehaviour
{
	private Transform target;           
	public float smoothing = 5f;
	public float smoothingRot = 1f;
	public GameObject [] targets;
	Vector3 offset;                     


	void FixedUpdate ()
	{targets = GameObject.FindGameObjectsWithTag("NeedDesk");
		
		Vector3 targetCamPos = targets[1].transform.position;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);


		Quaternion targetRot = targets[1].transform.rotation;
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRot, smoothingRot * Time.deltaTime);
	}
}