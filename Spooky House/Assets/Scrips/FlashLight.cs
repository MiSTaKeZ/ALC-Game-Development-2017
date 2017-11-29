using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour {
	
	public bool lightOn  = true;
	// Flashlight power capacity
	public int maxPower = 4;
	// Usualbe flashlight power
	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	public Text batteryText;


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

		batteryText.text = currentPower.ToString();

		if(currentPower > 0){
			StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
		}
	}
	public void setLightOn(){
		lightOn = true;
	}

	public bool isLightOn(){
		return lightOn;
	}

	IEnumerator BatteryDrain(float delay, int amount){
		yield return new WaitForSeconds(delay);
		currentPower -= amount;
		if(currentPower <= 0){
			currentPower = 0;
			print("Battery is DEAD!!! >=D");
			light.enabled = false;
		}
	}


}