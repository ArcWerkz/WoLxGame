using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fTileMASTER : MonoBehaviour {

	public  fighterPlc[] fMaster;




	public int fMASTER_type;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		fMaster[0].type = fMASTER_type;
		fMaster[1].type = fMASTER_type;

		if(Input.GetKeyDown(KeyCode.LeftShift)){
			if(Input.GetKeyUp(KeyCode.F)){
				F_T();

			}

		}

	}




	public void F_T(){

		switch (fMASTER_type){ 
		case 11:
			print ("All Fighter Types 11");
			break;

		case 10:
			print ("All Fighter Types 10");
			break;

		case 9:
			print ("All Fighter Types 9");
			break;

		case 8:
			print ("All Fighter Types 8");
			break;

		case 7:
			print ("All Fighter Types 7");
			break;

		case 6:
			print ("All Fighter Types 6");
			break;

		case 5:
			print ("All Fighter Types 5");
			break;

		case 4:
			print ("All Fighter Types 4");
			break;

		case 3:
			print ("All Fighter Types 3");
			break;

		case 2:
			print ("All Fighter Types 2");
			break;

		case 1:
			print ("All Fighter Types 1");
			break;

		default:
			print ("Select a Fighter Type");
			break;


		}


	}	
}


