using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIOff : MonoBehaviour {
	public GameObject UI;
	public GameObject UILESSON;
	public GameObject PlayButton;
	public GameObject PauseButton;
	public GameObject MenuPlane;
	//public GameObject Model;
	//public Component Translate;
	//public Component Rotate;
	//public Component Scale;
	public GameObject Paragraph1;
	public GameObject Paragraph2;
	public GameObject Plane;
	//public float counter;
	public Animator Fizzzra;
	public Animator Kavend;
	//public Animation Anim;
	//public GameObject LightSource;
	public GameObject Light;
	public float ButtonsCounter;
	public float NeedStart;
	public GameObject PausedParag;

	void Start (){
	//	Translate = Model.GetComponent<LeanTranslate> ();
	//	Rotate = Model.GetComponent<LeanRotate> ();
	//	Scale = Model.GetComponent<LeanScale>();
		UI.SetActive (true);
		UILESSON.SetActive (false);
		PauseButton.SetActive (false);
		ButtonsCounter = 1f;
		NeedStart = 0f;
		PausedParag = Paragraph1;
		//Light = LightSource.GetComponent<Light> ();
		//Next = null;
		//Prev = null;
	}

	public void STARTFUCKINGLESSON(){
		UI.SetActive (false);
	//	Translate.enabled = false;
	//	Rotate.enabled = false;
	//	Scale.enabled = false;
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
	/*public void Playyy (){
		counter = 0f;
		while (counter == 0f) {
			ParagraphAct1 ();
			new WaitForSeconds (5);
			ParagraphAct2 ();
		}
	}
		public void Pauuuuse(){
		counter++;
		}*/
	/*public void Inlight (){
			
	}
	public void OutLight(){
	
	}*/
/*public void StartAnim(){
		Anim.Play ();
}*/
public void  Kavendish(){
	Kavend.SetBool ("StartAn", true);
	Kavend.SetBool ("StopAn", true);
}

   public void FizraStart(){
	Fizzzra.SetBool ("Stop", false);
		Fizzzra.SetBool ("Start", true);

}
public void FizraStop ()
	{
		Fizzzra.SetBool ("Start", false);
		Fizzzra.SetBool ("Stop", true);
	}






}

