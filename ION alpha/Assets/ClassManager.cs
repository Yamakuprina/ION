using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClassManager : MonoBehaviour {


	public GameObject Classes;
	public GameObject Predmets;

	void Start(){
		Classes.SetActive (true);
		Predmets.SetActive (false);
	}

	// Update is called once per frame
	public void ClassesToSubjects(){
		StartCoroutine (Waitt ());
	}

	IEnumerator Waitt(){
		yield return new WaitForSeconds (0.7f);
		Classes.SetActive (false);
		Predmets.SetActive (true);
	}


	IEnumerator WaittGeom(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (1);

	}
	IEnumerator WaittPhys(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (2);
	}

	IEnumerator WaittBiology(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (3);
	}

	public void GeomPressed(){
		StartCoroutine (WaittGeom ());

	}

	public void PhysPressed(){
		StartCoroutine (WaittPhys ());

	}
	public void BiologyPressed(){
		StartCoroutine (WaittBiology ());

	}






}


