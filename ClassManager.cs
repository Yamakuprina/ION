using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClassManager : MonoBehaviour {

	public Animator Animm;
	public GameObject ClassCurrent;
	public GameObject Classes;
	public GameObject Predmets;
	// Use this for initialization
	void Start () {
		Animm = ClassCurrent.GetComponent<Animator> ();
	}
	// Update is called once per frame
	void OnMouseDown(){
		Animm.SetBool ("StartAnim", true);
	}
	void OnMouseUp(){
		Classes.SetActive (false);
		Predmets.SetActive (true);
	}
	IEnumerator Waitt(){
		yield return new WaitForSeconds (0.7f);
		Classes.SetActive (false);
		Predmets.SetActive (true);
	}

	public void ClassPerehod(){
		Animm.SetBool ("StartAnim", true);
		StartCoroutine (Waitt ());

	}
}
