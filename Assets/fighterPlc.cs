using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighterPlc : MonoBehaviour {

	public GameObject[] fighters;
	public int type;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyUp (KeyCode.F)) {
			fighter_type();

		}


	}

	public void fighter_type(){


		switch (type) {
		case 11:
			print ("Figher Type 11");
			var fgh11 = Instantiate (fighters[10], transform.position, transform.rotation);
			break;

		case 10:
			print ("Figher Type 10");
			var fgh10 = Instantiate (fighters[9], transform.position, transform.rotation);
			break;

		case 9:
			print ("Figher Type 9");
			var fgh9 = Instantiate (fighters[8], transform.position, transform.rotation);
			break;

		case 8:
			print ("Figher Type 8");
			var fgh8 = Instantiate (fighters[7], transform.position, transform.rotation);
			break;

		case 7:
			print ("Figher Type 7");
			var fgh7 = Instantiate (fighters[6], transform.position, transform.rotation);
			break;

		case 6:
			print ("Figher Type 6");
			var fgh6 = Instantiate (fighters[5], transform.position, transform.rotation);
			break;

		case 5:
			print ("Figher Type 5");
			var fgh5 = Instantiate (fighters[4], transform.position, transform.rotation);
			break;
		case 4:
			print ("Figher Type 4");
			var fgh4 = Instantiate (fighters[3], transform.position, transform.rotation);
			break;

		case 3:
			print ("Fighter Type 3");
			var fgh3 = Instantiate (fighters[2], transform.position, transform.rotation);
			break;

		case 2:
			print ("Fighter Type 2");
			var fgh2 = Instantiate (fighters[1], transform.position, transform.rotation);
			break;

		case 1:
			print ("Fighter Type 1");
			var fgh1 = Instantiate (fighters[0], transform.position, transform.rotation);
			break;

		default:
			print ("Select a Fighter Type");
			break;
		}
	}


}
