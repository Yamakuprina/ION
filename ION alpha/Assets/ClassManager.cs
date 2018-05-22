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


	public GameObject IMSURE1;
	//public GameObject IMSURE2;

	void Start(){
		Classes.SetActive (true);
		Predmets9.SetActive (false);
	}
	void Update (){
		if ((Input.GetKeyDown (KeyCode.Escape)) && (Predmets9.activeInHierarchy == true)) {
			Classes.SetActive (true);
			Predmets9.SetActive (false);
		}	
		if ((Input.GetKeyDown (KeyCode.Escape)) && (Razdely_Bio_9.activeInHierarchy == true)) {
			Predmets9.SetActive (true);
			Razdely_Bio_9.SetActive (false);
		}
		if ((Input.GetKeyDown (KeyCode.Escape)) && (Razdely_Geom_9.activeInHierarchy == true)) {
			Predmets9.SetActive (true);
			Razdely_Geom_9.SetActive (false);
		}	
		if ((Input.GetKeyDown (KeyCode.Escape)) && (Razdely_Phys_9.activeInHierarchy == true)) {
			Predmets9.SetActive (true);
			Razdely_Phys_9.SetActive (false);
		}	
	}

	public void Classes9ToSubjects(){
		StartCoroutine (Waitt9 ());
	}

	IEnumerator Waitt9(){
		yield return new WaitForSeconds (0.1f);
		Classes.SetActive (false);
		Predmets9.SetActive (true);
	}


	IEnumerator WaittGeom9(){
		yield return new WaitForSeconds (0.1f);
		Predmets9.SetActive (false);
		Razdely_Geom_9.SetActive (true);


	}
	IEnumerator WaittPhys9(){
		yield return new WaitForSeconds (0.1f);
		Predmets9.SetActive (false);
		Razdely_Phys_9.SetActive (true);
	}

	IEnumerator WaittBiology9(){
		yield return new WaitForSeconds (0.1f);
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





	public void IMSURE111(){
		IMSURE1.SetActive (true);
	}
	public void IMSURE111EXIT(){
		IMSURE1.SetActive (false);
	}
	/*public void IMSURE222(){
		IMSURE2.SetActive (true);
	}
	public void IMSURE222EXIT(){
		IMSURE2.SetActive (false);
	}*/

	public void Launch_Geometry_9_Perpendikulars (){
		SceneManager.LoadScene (1);
	}
	public void Launch_Phys_9_ZakonTyagotenya (){
		SceneManager.LoadScene (2);
	}
	public void Launch_Bio_9_RastitelnayaKletka (){
		SceneManager.LoadScene (3);
	}


}


