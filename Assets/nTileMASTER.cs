using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nTileMASTER : MonoBehaviour {

	public  navalPlc[] nMaster;




	public int nMASTER_type;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	

		nMaster[0].type = nMASTER_type;
		nMaster[1].type = nMASTER_type;
		nMaster[2].type = nMASTER_type;
		nMaster[3].type = nMASTER_type;

		nMaster[4].type = nMASTER_type;
		nMaster[5].type = nMASTER_type;
		nMaster[6].type = nMASTER_type;
		nMaster[7].type = nMASTER_type;

		nMaster[8].type = nMASTER_type;
		nMaster[9].type = nMASTER_type;


		if(Input.GetKeyDown(KeyCode.LeftShift)){
			if(Input.GetKeyUp(KeyCode.N)){
				N_T();

			}

		}

	}

	public void N_T(){

		switch (nMASTER_type) {
		case 4:
			print ("All Naval Types 4");

			break;

		case 3:
			print ("All Naval Types 3");

			break;

		case 2:
			print ("All Naval Types 2");

			break;

		case 1:
			print ("All Naval Types 1");

			break;

		default:
			print ("Select a Naval Type");
			break;


		}


	}

}
