using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterDeployment : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		initFBlockTravel ();


	}

	void initFBlockTravel(){
		transform.position += new Vector3 (0, 0, -1);



	}



	
}
