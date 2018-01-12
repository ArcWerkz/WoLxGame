using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerposition : MonoBehaviour {
	public GameObject pM;



	// Use this for initialization

	// Update is called once per frame
	void Update () {

	

		transform.position = pM.transform.position;

	
	}
}
