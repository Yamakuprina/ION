using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Off_Kavendish : MonoBehaviour {
	public GameObject UI; 
	public GameObject UILESSON; 
	public GameObject PlayButton; 
	public GameObject PauseButton; 
	public GameObject MenuPlane;

	public GameObject Model;
	public GameObject SelectModel;
	public Animator SelectModelAnim;
	public GameObject SelectDesk;


	public GameObject Paragraph1; 
	public GameObject Paragraph2; 
	public GameObject Paragraph3; 
	public GameObject Paragraph4; 
	public GameObject Paragraph5; 
	public GameObject Paragraph6; 
	public GameObject Paragraph7;
	//public GameObject Paragraph8;
	//public GameObject Paragraph9;

	public GameObject Plane;

	public Animator Kavend;

	public GameObject FirstLighted; 
	public GameObject SecondLighted;
	public Animator FirstLightedAnim;
	public Animator SecondLightedAnim;
	//public GameObject FailedPerp1;
	//public GameObject FailedPerp2;
	//public GameObject FailedPerp3;
	//public GameObject RibosomyLighted;
	//public GameObject GoldzhyLighted;
	//public GameObject YadroLighted;


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
		FirstLighted.SetActive (false);
		SecondLighted.SetActive (false);
	} 



	public void STARTFUCKINGLESSON(){ 
		UI.SetActive (false); 
		UILESSON.SetActive (true);} 






	public void PlaytoPause (){ 
		if (NeedStart == 0) { 
			NeedStart++; 
		} 
		if ((ButtonsCounter == 4)&(NeedStart == 1)) { 
			FirstLighted.transform.localScale = new Vector3 (1, 1, 1);
		} 
		if ((ButtonsCounter == 5)&(NeedStart == 1)) { 
			SecondLighted.transform.localScale = new Vector3 (1, 1, 1); 
		} 
		Light.SetActive (true); 
		Plane.SetActive (true); 
		PausedParag.SetActive (true); 
		PlayButton.SetActive (false); 
		PauseButton.SetActive (true); 
	} 



	public void PausetoPlay (){ 

		if (NeedStart == 1) { 
			NeedStart--;} 



		if (Paragraph1.activeInHierarchy == true) { 
			PausedParag = Paragraph1; 
		} 
		if (Paragraph2.activeInHierarchy == true) { 
			PausedParag = Paragraph2; 
		} 
		if (Paragraph3.activeInHierarchy == true) { 
			PausedParag = Paragraph3; 
		} 
		if (Paragraph4.activeInHierarchy == true) { 
			PausedParag = Paragraph4; 
		} 
		if (Paragraph5.activeInHierarchy == true) {
			PausedParag = Paragraph5;
		}
		if (Paragraph5.activeInHierarchy == true) { 
			PausedParag = Paragraph5; 
		} 
		if (Paragraph6.activeInHierarchy == true) { 
			PausedParag = Paragraph6; 
		} 
		if (Paragraph7.activeInHierarchy == true) { 
			PausedParag = Paragraph7; 
		}
		/*if (Paragraph8.activeInHierarchy == true) { 
			PausedParag = Paragraph8; 
		}
		if (Paragraph9.activeInHierarchy == true) { 
			PausedParag = Paragraph9; 
		}*/


		//YadroLighted.SetActive (false);
		//GoldzhyLighted.SetActive (false);
		SecondLighted.transform.localScale = new Vector3 (0, 0, 0); 
		FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
		//FailedPerp1.SetActive (true);
		//FailedPerp2.SetActive (true);
		//FailedPerp3.SetActive (true);
		//RibosomyLighted.SetActive (false); 


		//Paragraph9.SetActive (false);
		//Paragraph8.SetActive (false);
		Paragraph7.SetActive (false);
		Paragraph6.SetActive (false); 
		Paragraph5.SetActive (false); 
		Paragraph4.SetActive (false); 
		Paragraph3.SetActive (false); 
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


		if (ButtonsCounter == 8) { 
			ButtonsCounter--; 
		}//Verhnya granica ButtonsCounter'a 





		if ((ButtonsCounter == 2)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//			Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
Paragraph7.SetActive (false); 
Paragraph6.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph2.SetActive (true); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//GoldzhyLighted.SetActive (false);
			//YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (false);
		} 
		if ((ButtonsCounter == 3)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
						Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
Paragraph6.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph3.SetActive (true);  
			//RibosomyLighted.SetActive (false); 
			//GoldzhyLighted.SetActive (false);
			//YadroLighted.SetActive (false);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (false);
			//FailedPerp1.SetActive (true);
		} 
		if ((ButtonsCounter == 4)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
					Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
Paragraph6.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph4.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (1, 1, 1); 
			//	GoldzhyLighted.SetActive (false);
			//	YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (false);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (true);

		} 
		if ((ButtonsCounter == 5)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
					Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
Paragraph6.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph5.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (true);
			//RibosomyLighted.SetActive (false); 
			//			GoldzhyLighted.SetActive (false);
			//			YadroLighted.SetActive (false);
			SecondLighted.transform.localScale = new Vector3 (1, 1, 1);  

		} 
		if ((ButtonsCounter == 6)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
					Paragraph7.SetActive (false);
			//		Paragraph8.SetActive (false);
			//		Paragraph9.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false);
			Paragraph6.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false); 
			//RibosomyLighted.SetActive (true); 

		} 
		if ((ButtonsCounter == 7)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//			Paragraph8.SetActive (false);
			//			Paragraph9.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false);
			Paragraph7.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//RibosomyLighted.SetActive (false);
			//YadroLighted.SetActive (false);
			//GoldzhyLighted.SetActive (true);

		}
		if ((ButtonsCounter == 8)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//Paragraph7.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			//Paragraph6.SetActive (false);
			//Paragraph8.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//RibosomyLighted.SetActive (false);
			//GoldzhyLighted.SetActive (false);
			//YadroLighted.SetActive (true);

		}
		if ((ButtonsCounter == 9)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//Paragraph7.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			//Paragraph6.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (true);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//RibosomyLighted.SetActive (false);
			//GoldzhyLighted.SetActive (false);
			//YadroLighted.SetActive (false);

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
			Paragraph4.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false);
			//			Paragraph8.SetActive (false);
			Paragraph7.SetActive (false);
			//			Paragraph9.SetActive (false);
			Paragraph1.SetActive (true); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 
		} 
		if ((ButtonsCounter == 2)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
			Paragraph4.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph7.SetActive (false);
			//			Paragraph8.SetActive (false);
			//			Paragraph9.SetActive (false);
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph2.SetActive (true); 
			//RibosomyLighted.SetActive (false); 
			//			GoldzhyLighted.SetActive (false);
			//			YadroLighted.SetActive (false);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (false);
		} 
		if ((ButtonsCounter == 3)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph7.SetActive (false);
			//			Paragraph8.SetActive (false);
			//			Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph3.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (false);
			//FailedPerp1.SetActive (true);
		} 
		if ((ButtonsCounter == 4)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph7.SetActive (false);
			//		Paragraph8.SetActive (false);
			//		Paragraph9.SetActive (false);
			Paragraph3.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph4.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (1, 1, 1); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 
			//FailedPerp3.SetActive (false);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (true);

		} 
		if ((ButtonsCounter == 5)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph7.SetActive (false);
			//		Paragraph8.SetActive (false);
			//		Paragraph9.SetActive (false);
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (true);
			//FailedPerp3.SetActive (true);
			//FailedPerp2.SetActive (true);
			//FailedPerp1.SetActive (true);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (1, 1, 1);  
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false);
			//RibosomyLighted.SetActive (false); 

		} 
		if ((ButtonsCounter == 6)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true); 
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph7.SetActive (false);
			//		Paragraph8.SetActive (false);
			//		Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//		GoldzhyLighted.SetActive (false);
			//		YadroLighted.SetActive (false); 
			//RibosomyLighted.SetActive (true); 

		}
		if ((ButtonsCounter == 7)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//			Paragraph8.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false);
			//			Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false);
			Paragraph7.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0); 
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//RibosomyLighted.SetActive (false);
			//	YadroLighted.SetActive (false);
			//	GoldzhyLighted.SetActive (true);

		} 
		if ((ButtonsCounter == 8)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//	Paragraph7.SetActive (false); 
			Paragraph5.SetActive (false); 
			//	Paragraph9.SetActive (false);
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			//	Paragraph6.SetActive (false);
			//	Paragraph8.SetActive (true); 
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//RibosomyLighted.SetActive (false);
			//	GoldzhyLighted.SetActive (false);
			//	YadroLighted.SetActive (true);

		}
		if ((ButtonsCounter == 9)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			//	Paragraph7.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			//	Paragraph6.SetActive (false);
			//	Paragraph8.SetActive (false);
			//	Paragraph9.SetActive (true);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			//	RibosomyLighted.SetActive (false);
			//	GoldzhyLighted.SetActive (false);
			//	YadroLighted.SetActive (false);

		}





	}
	public void  Kavendish(){
			FirstLighted.SetActive (true);
			FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
			FirstLightedAnim.SetBool ("StopAn", false);
			FirstLightedAnim.SetBool ("StartAn", true);

			SecondLighted.SetActive (true);
			SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
			SecondLightedAnim.SetBool ("StopAn", false);
			SecondLightedAnim.SetBool ("StartAn", true);

			SelectModel.SetActive (true);
			SelectModel.transform.localScale = new Vector3 (0, 0, 0);
			SelectModelAnim.SetBool ("StopAn", false);
			SelectModelAnim.SetBool ("StartAn", true);

			Kavend.SetBool ("StopAn", false);
			Kavend.SetBool ("StartAn", true);
		
	}
	public void  KavendishSTOP(){
		FirstLighted.SetActive (true);
		FirstLighted.transform.localScale = new Vector3 (0, 0, 0);
		FirstLightedAnim.SetBool ("StartAn", false);
		FirstLightedAnim.SetBool ("StopAn", true);

		SecondLighted.SetActive (true);
		SecondLighted.transform.localScale = new Vector3 (0, 0, 0);
		SecondLightedAnim.SetBool ("StartAn", false);
		SecondLightedAnim.SetBool ("StopAn", true);


		SelectModel.SetActive (true);
		SelectModel.transform.localScale = new Vector3 (0, 0, 0);
		SelectModelAnim.SetBool ("StartAn", false);
		SelectModelAnim.SetBool ("StopAn", true);

		Kavend.SetBool ("StartAn", false);
		Kavend.SetBool ("StopAn", true);
	}


	public void SelectedDesk(){
		SelectDesk.SetActive (true);
	}
	public void SelectedDeskStop(){
		SelectDesk.SetActive (false);
	}
	public void SelectedModel(){
		SelectModel.SetActive (true);
		SelectModel.transform.localScale = new Vector3 (1, 1, 1);
	}
	public void SelectedModelStop(){
		SelectModel.transform.localScale = new Vector3 (0, 0, 0);
	}





}
