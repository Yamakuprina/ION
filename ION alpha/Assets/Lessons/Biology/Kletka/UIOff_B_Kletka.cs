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
	public GameObject Paragraph3; 
	public GameObject Paragraph4; 
	public GameObject Paragraph5; 
	public GameObject Paragraph6; 

	public GameObject Plane; 

	public GameObject MembranaLighted; 
	public GameObject MitohondriyaLighted; 
	public GameObject VakuolLighted; 
	public GameObject RibosomyLighted; 


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
		UILESSON.SetActive (true);} 






	public void PlaytoPause (){ 
		if (NeedStart == 0) { 
			NeedStart++; 
		} 


		if (ButtonsCounter == 2) { 
			MembranaLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 3) { 
			MitohondriyaLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 4) { 
			VakuolLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 5) { 
			VakuolLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 6) { 
			RibosomyLighted.SetActive (true); 
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
		if (Paragraph6.activeInHierarchy == true) { 
			PausedParag = Paragraph6; 
		} 


		MitohondriyaLighted.SetActive (false); 
		MembranaLighted.SetActive (false); 
		VakuolLighted.SetActive (false); 
		RibosomyLighted.SetActive (false); 


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


		if (ButtonsCounter == 7) { 
			ButtonsCounter--; 
		}//Verhnya granica ButtonsCounter'a 





		if ((ButtonsCounter == 2)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph6.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph2.SetActive (true); 
MitohondriyaLighted.SetActive(false); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MembranaLighted.SetActive (true); 
} 
if ((ButtonsCounter == 3)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph6.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph3.SetActive (true); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MembranaLighted.SetActive (false); 
MitohondriyaLighted.SetActive(true); 
} 
if ((ButtonsCounter == 4)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph6.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph4.SetActive (true); 
MembranaLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
VakuolLighted.SetActive (true); 

} 
if ((ButtonsCounter == 5)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph6.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph5.SetActive (true); 
MembranaLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
VakuolLighted.SetActive (true); 

} 
if ((ButtonsCounter == 6)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph5.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph6.SetActive (true); 
MembranaLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (true); 

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
Paragraph1.SetActive (true); 
MitohondriyaLighted.SetActive(false); 
MembranaLighted.SetActive (false); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
} 
if ((ButtonsCounter == 2)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph4.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph6.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph2.SetActive (true); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
MembranaLighted.SetActive (true); 
} 
if ((ButtonsCounter == 3)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph1.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph6.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph3.SetActive (true); 
VakuolLighted.SetActive (false); 
MembranaLighted.SetActive (false); 
RibosomyLighted.SetActive (false); 
MitohondriyaLighted.SetActive(true); 
} 
if ((ButtonsCounter == 4)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph6.SetActive (false); 
Paragraph5.SetActive (false); 
Paragraph4.SetActive (true); 
MembranaLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
RibosomyLighted.SetActive (false); 
VakuolLighted.SetActive (true); 

} 
if ((ButtonsCounter == 5)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph6.SetActive (false); 
Paragraph5.SetActive (true); 
MembranaLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
RibosomyLighted.SetActive (false); 
VakuolLighted.SetActive (true); 

} 
if ((ButtonsCounter == 6)&&(NeedStart>0)) { 

Light.SetActive (true); 
Plane.SetActive (true); 
Paragraph5.SetActive (false); 
Paragraph1.SetActive (false); 
Paragraph2.SetActive (false); 
Paragraph3.SetActive (false); 
Paragraph4.SetActive (false); 
Paragraph6.SetActive (true); 
MembranaLighted.SetActive (false); 
MitohondriyaLighted.SetActive(false); 
VakuolLighted.SetActive (false); 
RibosomyLighted.SetActive (true); 

}






	} 





}





