using System.Collections;
using UnityEngine;

public class GhostHeath : MonoBehaviour {

	// bool lightCheck;

	// Use this for initialization
	
	void Start () {
		// lightCheck = GetComponent<Flashlight>().LightOn;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.name == "Ghost"){
			print("Ghost is Stunned!");
		}
	}
}
