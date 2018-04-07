using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIOff : MonoBehaviour {
	public GameObject UI;
	public GameObject StartLesson;
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
	//public GameObject Next;
	//public GameObject Prev;
	// Use this for initialization
	void Start (){
	//	Translate = Model.GetComponent<LeanTranslate> ();
	//	Rotate = Model.GetComponent<LeanRotate> ();
	//	Scale = Model.GetComponent<LeanScale>();
		StartLesson.SetActive (false);
		UILESSON.SetActive (false);
		PauseButton.SetActive (false);
		//Light = LightSource.GetComponent<Light> ();
		//Next = null;
		//Prev = null;
	}
	public void UIOfff (){
		UI.SetActive (false);
		StartLesson.SetActive (true);
	}
	public void STARTFUCKINGLESSON(){
	//	Translate.enabled = false;
	//	Rotate.enabled = false;
	//	Scale.enabled = false;
		UILESSON.SetActive (true);
		StartLesson.SetActive (false);
	}

	public void PlaytoPause (){
		Light.SetActive (true);
		Plane.SetActive (true);
		Paragraph2.SetActive (false);
		Paragraph1.SetActive (true);
		PlayButton.SetActive (false);
		PauseButton.SetActive (true);
	}
	public void PausetoPlay (){
		Paragraph1.SetActive (false);
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
	public void ParagraphAct1(){
		Light.SetActive (true);
		Plane.SetActive (true);
		Paragraph2.SetActive (false);
		Paragraph1.SetActive (true);
	}
	public void ParagraphAct2(){
		Light.SetActive (true);
		Plane.SetActive (true);
		Paragraph1.SetActive (false);
		Paragraph2.SetActive (true);
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
public void  KavendishStop(){
	Kavend.SetBool ("StartAn", false);
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

