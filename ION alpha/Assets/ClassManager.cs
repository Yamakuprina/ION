using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClassManager : MonoBehaviour {


	public GameObject Classes;
	public GameObject Predmets9;
	public GameObject Razdely_Geom_9;
	public GameObject Razdely_Phys_9;
	public GameObject Razdely_Bio_9;

	void Start(){
		Classes.SetActive (true);
		Predmets9.SetActive (false);
	}


	public void Classes9ToSubjects(){
		StartCoroutine (Waitt9 ());
	}

	IEnumerator Waitt9(){
		yield return new WaitForSeconds (0.7f);
		Classes.SetActive (false);
		Predmets9.SetActive (true);
	}


	IEnumerator WaittGeom9(){
		yield return new WaitForSeconds (0.7f);
		Predmets9.SetActive (false);
		Razdely_Geom_9.SetActive (true);


	}
	IEnumerator WaittPhys9(){
		yield return new WaitForSeconds (0.7f);
		Predmets9.SetActive (false);
		Razdely_Phys_9.SetActive (true);
	}

	IEnumerator WaittBiology9(){
		yield return new WaitForSeconds (0.7f);
		Predmets9.SetActive (false);
		Razdely_Bio_9.SetActive (true);
	}

	public void Geom9Pressed(){
		StartCoroutine (WaittGeom9 ());

	}

	public void Phys9Pressed(){
		StartCoroutine (WaittPhys9 ());

	}
	public void Biology9Pressed(){
		StartCoroutine (WaittBiology9 ());

	}






}


