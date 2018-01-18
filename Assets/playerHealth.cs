using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour {

	public playerVitals vitals;

	public Image hIcon;
	public float _fill;

	public int initHealth;
	public int currHealth;
	public float hedgeVal = 0.001f;
	public int testDMG;

	void Awake(){
		
	}



	// Use this for initialization
	void Start () {

		initHealth = vitals.healthVal;

		testDMG = 50;
		currHealth = initHealth;



	}


	// Update is called once per frame
 void Update () {

		_fill = ((float)currHealth * hedgeVal) + hedgeVal;
		hIcon.fillAmount = _fill;

		if (Input.GetKeyUp (KeyCode.H)) {
			subtrHP();
			Debug.Log(testDMG);
		}

	}


	void subtrHP(){
		

			currHealth -= testDMG;
		}

}

	






