using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretPlc : MonoBehaviour {

	public GameObject[] turrets;
	public int type;



	void Awake () {
		
	}



	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.T)) {
			turret_type();
		
		}


	}

	public void turret_type(){





			switch (type) {

		case 4:
			print ("Turret Type 4");
			var tur4 = Instantiate (turrets[3], transform.position, transform.rotation);
				break;

			case 3:
				print ("Turret Type 3");
			var tur3 = Instantiate (turrets[2], transform.position, transform.rotation);
				break;

			case 2:
				print ("Turret Type 2");
			var tur2 = Instantiate (turrets[1], transform.position, transform.rotation);
				break;

			case 1:
				print ("Turret Type 1");
			var tur1 = Instantiate (turrets[0], transform.position, transform.rotation);
				break;

			default:
				print ("Select a Turret Type");
				break;
			}
		}



}
