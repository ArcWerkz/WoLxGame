using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileMASTER : MonoBehaviour {

	public  turretPlc[] Master;




	public int MASTER_type;



	




	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

		Master[0].type = MASTER_type;
		Master[1].type = MASTER_type;
		Master[2].type = MASTER_type;
		Master[3].type = MASTER_type;

		Master[4].type = MASTER_type;
		Master[5].type = MASTER_type;
		Master[6].type = MASTER_type;
		Master[7].type = MASTER_type;

		Master[8].type = MASTER_type;
		Master[9].type = MASTER_type;
		Master[10].type = MASTER_type;
		Master[11].type = MASTER_type;

		Master[12].type = MASTER_type;
		Master[13].type = MASTER_type;
		Master[14].type = MASTER_type;
		Master[15].type = MASTER_type;
		Master[16].type = MASTER_type;
	

		if(Input.GetKeyDown(KeyCode.LeftShift)){
			if(Input.GetKeyUp(KeyCode.T)){
			M_T();

		}

		}

	}


	public void M_T(){

		switch (MASTER_type) {
		case 4:
			print ("All Turret Types 4");

			break;

		case 3:
			print ("All Turret Types 3");

			break;

		case 2:
			print ("All Turret Types 2");

			break;

		case 1:
			print ("All Turret Types 1");

			break;

		default:
			print ("Select a Turret Type");
			break;


		}


	}
}
