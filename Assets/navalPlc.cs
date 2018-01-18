using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navalPlc : MonoBehaviour {

	public GameObject[] navals;
	public int type;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.N)) {
			naval_type();

		}

		
	}

	public void naval_type(){





		switch (type) {
		case 6:
			
			print ("Naval Type 6");
			var nav6 = Instantiate (navals[5], transform.position, transform.rotation);
			break;

		case 5:
			
			print ("Naval Type 5");
			var nav5 = Instantiate (navals[4], transform.position, transform.rotation);
			break;

		case 4:
			
			print ("Naval Type 4");
			var nav4 = Instantiate (navals[3], transform.position, transform.rotation);
			break;

		case 3:
			
			print ("Naval Type 3");
			var nav3 = Instantiate (navals[2], transform.position, transform.rotation);
			break;

		case 2:
			
			print ("Naval Type 2");
			var nav2 = Instantiate (navals[1], transform.position, transform.rotation);
			break;

		case 1:
			
			print ("Naval Type 1");
			var nav1 = Instantiate (navals[0], transform.position, transform.rotation);
			break;

		default:
			print ("Select a Naval Type");
			break;
		}
	}

}
