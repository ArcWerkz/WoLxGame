using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerVitals : MonoBehaviour {

	public GameObject[] dragons;

	public Hashtable stats;

	public Hashtable attributes;

	public string dragon_name;

	public int lcapVal;
	public int levelVal;
	public int healthVal;
	public int firerateVal;
	public int skillVal;
	public int crsVal;
	public int lrsVal;

	public int armorVal;
	public int defenseVal;
	public int speedVal;
	public int accuracyVal;

	public int dragon_type;

	void Awake(){
		setDragon ();



	}

	void Start(){
		initStats ();
		initAttributes ();
		render_dragon ();

	}

	void initStats(){
		stats = new Hashtable();
		stats ["Name"] = dragon_name;

		stats["Level Cap"] = lcapVal;
		stats["Level"] = levelVal;
		stats["Health"] = healthVal;
		stats["Fire Rate"] =firerateVal;
		stats["Skill Charge"] = skillVal;
		stats["Close Range"] = crsVal;
		stats["Long Range"] = lrsVal;



	}

	void initAttributes(){
		attributes = new Hashtable();

		attributes ["Armor"] = armorVal;
		attributes ["Defense"] = defenseVal;
		attributes ["Speed"] = speedVal;
		attributes ["Accuracy"] = accuracyVal;


	}

	void setDragon(){
	switch(dragon_type){

	case 1:
		dragon_name = "Veirhorn";
		lcapVal = 25;
		levelVal = 1;
		healthVal = 900;
		firerateVal = 30;
		skillVal = 400;
		crsVal = 350;
		lrsVal = 600;

		armorVal = 3;
		defenseVal = 4;
		speedVal = 5;
		accuracyVal = 6; 

		

		break;

		case 2:
			dragon_name = "Fellwing";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 900;
			firerateVal = 30;
			skillVal = 400;
			crsVal = 350;
			lrsVal = 600;

			armorVal = 4;
			defenseVal = 6;
			speedVal = 4;
			accuracyVal = 4; 
			break;

		case 3:
			dragon_name = "Heralder";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 700;
			firerateVal = 40;
			skillVal = 500;
			crsVal = 180;
			lrsVal = 780;

			armorVal = 1;
			defenseVal = 3;
			speedVal = 6;
			accuracyVal = 7; 
			break;

		case 4:
			dragon_name = "Eios";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 1400;
			firerateVal = 35;
			skillVal = 600;
			crsVal = 375;
			lrsVal = 800;

			armorVal = 4;
			defenseVal = 5;
			speedVal = 5;
			accuracyVal = 7; 
			break;

		case 5:
			dragon_name = "Arceus";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 1200;
			firerateVal = 25;
			skillVal = 520;
			crsVal = 410;
			lrsVal = 700;

			armorVal = 5;
			defenseVal = 7;
			speedVal = 4;
			accuracyVal = 5; 
			break;

		case 6:
			dragon_name = "Crimson-maw";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 1000;
			firerateVal = 20;
			skillVal = 400;
			crsVal = 485;
			lrsVal = 450;

			armorVal = 6;
			defenseVal = 7;
			speedVal = 5;
			accuracyVal = 4; 
			break;

		case 7:
			dragon_name = "Nightmare";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 1600;
			firerateVal = 20;
			skillVal = 750;
			crsVal = 310;
			lrsVal = 890;

			armorVal = 3;
			defenseVal = 5;
			speedVal = 3;
			accuracyVal = 8; 
			break;

		case 8:
			dragon_name = "Fenix";
			lcapVal = 25;
			levelVal = 1;
			healthVal = 2000;
			firerateVal = 25;
			skillVal = 700;
			crsVal = 460;
			lrsVal = 985;

			armorVal = 5;
			defenseVal = 7;
			speedVal = 6;
			accuracyVal = 6; 
			break;

		default:
			Debug.Log ("Choose a Dragon: 1-8.");
		break;

	}


}


	void render_dragon(){
		switch(dragon_type){

		case 1:
			dragons [0].SetActive (true);
			dragons [1].SetActive (false);
			dragons [2].SetActive (false);
			dragons [3].SetActive (false);
			dragons [4].SetActive (false);
			dragons [5].SetActive (false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);

			break;

		case 2:

			dragons[0].SetActive(false);
			dragons[1].SetActive(true);
			dragons[2].SetActive(false);
			dragons[3].SetActive(false);
			dragons[4].SetActive(false);
			dragons[5].SetActive(false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);

			break;

		case 3:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(true);
			dragons[3].SetActive(false);
			dragons[4].SetActive(false);
			dragons[5].SetActive(false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);


			break;

		case 4:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(false);
			dragons[3].SetActive(true);
			dragons[4].SetActive(false);
			dragons[5].SetActive(false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);


			break;

		case 5:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(false);
			dragons[3].SetActive(false);
			dragons[4].SetActive(true);
			dragons[5].SetActive(false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);


			break;

		case 6:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(false);
			dragons[3].SetActive(false);
			dragons[4].SetActive(false);
			dragons[5].SetActive(true);
			dragons[6].SetActive(false);
			dragons[7].SetActive(false);

			break;

		case 7:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(false);
			dragons[3].SetActive(false);
			dragons[4].SetActive(false);
			dragons[5].SetActive(false);
			dragons[6].SetActive(true);
			dragons[7].SetActive(false);

			break;

		case 8:

			dragons[0].SetActive(false);
			dragons[1].SetActive(false);
			dragons[2].SetActive(false);
			dragons[3].SetActive(false);
			dragons[4].SetActive(false);
			dragons[5].SetActive(false);
			dragons[6].SetActive(false);
			dragons[7].SetActive(true);


			break;

		default:
			Debug.Log("Select a Dragon Type [1-8]");
			break;

		}

	}
	}

