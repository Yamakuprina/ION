using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIOff_B_Kletka : MonoBehaviour {
	public GameObject UI;
	public GameObject UILESSON;
	public GameObject PlayButton;
	public GameObject PauseButton;
	public GameObject MenuPlane;
	public GameObject Paragraph1;
	public GameObject Paragraph2;
	public GameObject Plane;
	public GameObject MembranaLighted;
	public GameObject Light;
	public float ButtonsCounter;
	public float NeedStart;
	public GameObject PausedParag;

	void Start (){
		
		UI.SetActive (true);
		UILESSON.SetActive (false);
		PauseButton.SetActive (false);
		ButtonsCounter = 1f;
		NeedStart = 0f;
		PausedParag = Paragraph1;

	}

	public void STARTFUCKINGLESSON(){
		UI.SetActive (false);
		UILESSON.SetActive (true);

	}

	public void PlaytoPause (){
		if (NeedStart == 0) {
			NeedStart++;
		}
		Light.SetActive (true);
		Plane.SetActive (true);
		PausedParag.SetActive (true);
		PlayButton.SetActive (false);
		PauseButton.SetActive (true);
	}
	public void PausetoPlay (){
		if (NeedStart == 1) {
			NeedStart--;
		}
		if (Paragraph1.activeInHierarchy == true) {
			PausedParag = Paragraph1;
		}
		if (Paragraph2.activeInHierarchy == true) {
			PausedParag = Paragraph2;
		}
		MembranaLighted.SetActive (false);
		Paragraph2.SetActive (false);
		Paragraph1.SetActive (false);
		Plane.SetActive (false);
		PauseButton.SetActive (false);
		PlayButton.SetActive (true);
	}
	public void PauseMenuu (){
		UILESSON.SetActive (false);
		MenuPlane.SetActive (true);
	}
	public void PauseMenuuBack (){
		MenuPlane.SetActive (false);
		UILESSON.SetActive (true);

	}
	public void PauseMenuuBacktoStart (){
		SceneManager.LoadScene (0);

	}
	public void Next (){ 
		if (NeedStart>0f){
		ButtonsCounter++;
		}
		if (ButtonsCounter == 3) {
			ButtonsCounter--;
		}
		if ((ButtonsCounter == 2)&&(NeedStart>0)) {
			
			Light.SetActive (true);
			Plane.SetActive (true);
			Paragraph1.SetActive (false);
			Paragraph2.SetActive (true);
			MembranaLighted.SetActive (true);
		}
	
	}
	public void Prev(){
		if (NeedStart > 0f) {
			ButtonsCounter--;
		}
		if (ButtonsCounter == 0) {
			ButtonsCounter++;
		}
		if ((ButtonsCounter == 1)&&(NeedStart>0)) {
			Light.SetActive (true);
			Plane.SetActive (true);
			Paragraph2.SetActive (false);
			Paragraph1.SetActive (true);
		}
	}







}

