using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermove : MonoBehaviour {
	public GameObject pM;
	public Slider sld;
	// Use this for initialization
	public void sliderChng (float newValue) {



		Vector3 pos = pM.transform.position;

		pos.x = newValue;
		pM.transform.position = pos;




	// Update is called once per frame
	


	
}	
	void Update(){
		transform.position += new Vector3(0,0,-1);

	}

}
