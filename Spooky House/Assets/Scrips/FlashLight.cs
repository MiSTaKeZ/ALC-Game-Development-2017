using Styem.Collections;
using UnityEngine;
using System.Collections.Generic;

public class FlashLight; MonoBehaviour {
	public bool light on;

	Light light;



	// Use this for initialization
	void Start () {
		Light = GetComponent<Light> ();
		//Set Light default to ON
		lightOn = true; 
		light.enable = true;

	}
	
	// Update is called once per frame
	void Update () {
	// Togle light on/off when L key is pressed.
	if (Input.GetKeyUp (KeyCode.F) && lightOn)  {
		lightOn = false;
		light.enable = false;

	}

	else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
		lightOn = true;
		light.enabled = true;

		}
	}
}