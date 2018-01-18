using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerSkillCharge : MonoBehaviour {

	public playerVitals vitals;

	public Image sIcon;
	public float _fill;

	public int initCharge;
	public int currCharge;
	public float hedgeVal = 0.001f;
	public int testSK;

	void Awake(){

	}



	// Use this for initialization
	void Start () {

		initCharge = vitals.skillVal;

		testSK = 50;
		currCharge = initCharge;



	}


	// Update is called once per frame
	void Update () {

		_fill = ((float)currCharge * hedgeVal) + hedgeVal;
		sIcon.fillAmount = _fill;

		if (Input.GetKeyUp (KeyCode.S)) {
			subtrSK();
			Debug.Log(testSK);
		}

	}


	void subtrSK(){


		currCharge -= testSK;
	}

}


	

