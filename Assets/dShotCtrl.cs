using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dShotCtrl : MonoBehaviour {

	public GameObject pM;
	public float speed;
	public float rate;

	void Start(){
		speed = 100.0f;
		float ts = Time.deltaTime * 3;
		rate = speed * ts;

	}

	// Use this for initialization
	void orient(float newDir){

		Vector3 pos = pM.transform.position;

		pos.x = newDir;
		pM.transform.position = pos;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, -1) * rate;
	}
}
