using System.Collections;
using UnityEngine;

public class GhostHeath : MonoBehaviour {

	bool lightCheck;
	FlashLight flash;
	public GameObject ghost;

	// bool lightCheck;

	// Use this for initialization
	
	void Start () {
		//print("Obj ;" +gameobject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>());
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>();
		//bool test = gameObject.GetComponentInChildren<Light>().FlashLight.isLightOn();
		//print("Test:"+test);
		print("Obj:"+flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is Stunned!");
			// other.GetComponent<Rigidbody>().Velocity = Vector3.zero;
			// other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			other.GetComponent<Ghost>().moveSpeed = 0f;
			StartCoroutine(Wait(5));
			//StopCoroutine(Wait(5));
			
		}	
	}

	IEnumerator Wait(float time){
			yield return new WaitForSeconds(time);
			ghost.GetComponent<Ghost>().moveSpeed = 5f;
			print("Ghost is unstunned");

	}			




}