using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour {
	public GameObject pM;
	public Slider sld;

	public GameObject dsh;
	public Transform dsL; 




	// Use this for initialization
	public void sliderChng (float newValue) {



		Vector3 pos = pM.transform.position;

		pos.x = newValue;
		pM.transform.position = pos;

	}



	void Start(){
		
	






	}


	void Update(){
		transform.position += new Vector3 (0, 0, -1);



		if (Input.GetKeyDown (KeyCode.A)) {

			fire ();

		}

	}

	void fire(){
		
		var shot = (GameObject)Instantiate (dsh, dsL.position ,dsL.rotation);
		Destroy (shot, 1.0f);

	}

		
}
