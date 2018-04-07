using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PredmetManager : MonoBehaviour {
	public Animator PhysAnim;
	public Animator GeomAnim;
	public Animator AstroAnim;
	public GameObject GeomPlane;
	public GameObject GeomImage;
	public GameObject PhysPlane;
	public GameObject PhysImage;


	IEnumerator WaittGeom(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (1);

	}
	IEnumerator WaittPhys(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (2);
	}
	IEnumerator WaittAstro(){
		yield return new WaitForSeconds (1.5f);
		//SceneManager.LoadScene (3);
	}

	public void GeomPressed(){
		GeomAnim.SetBool ("Start", true);
		StartCoroutine (WaittGeom ());

	}

	public void PhysPressed(){
		GeomImage.SetActive (false);
		GeomPlane.SetActive (false);
		PhysPlane.SetActive (true);
		PhysImage.SetActive (true);
		PhysAnim.SetBool ("Start", true);
		StartCoroutine (WaittPhys ());

	}
	public void AstroPressed(){
		AstroAnim.SetBool ("Start", true);
		StartCoroutine (WaittAstro ());

	}
}
