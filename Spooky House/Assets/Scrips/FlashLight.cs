﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
	
	public bool lightOn  = true;
	// Flashlight power capacity
	public int maxPower = 4;
	// Usualbe flashlight power
	public int currentPower;

	Light light;

	// Use this for initialization
	void Start () {
		currentPower = maxPower;
		print("Power = " + maxPower);
		light = GetComponent<Light> ();
		//Set Light default to ON
		lightOn = true; 
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Togle light on/off when F key is pressed.
		if (Input.GetKeyUp (KeyCode.F) && lightOn) {
			lightOn = false;
			light.enabled = false;

		}

		else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
			print("Light On");
			lightOn = true;
			light.enabled = true;

		}
	}
	public void setLightOn(){
		lightOn = true;
	}

	public bool isLightOn(){
		return lightOn;
	}

}