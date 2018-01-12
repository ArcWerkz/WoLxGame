using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settoplayer : MonoBehaviour {
	public Camera cam1;
	public Transform player;
	// Use this for initialization
	public void setp(Transform player){
		cam1.transform.SetParent (player);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
