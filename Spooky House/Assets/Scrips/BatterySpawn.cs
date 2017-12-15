using UnityEngine;
using System.Collections;

public class BatterySpawn : MonoBehaviour {

	public GameObject battery;

	pulbic Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;



	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(batSpawned == False){
			StartCoroutine(SpawnBat, battery));
			
		}
		else{
			StopCoroutine(SpawnBat(spawnTime, battery));
		}
	}

	void OnTriggerEnter(Collisoin other){
		if(other.GameObject.tag == "battery"){
			batSpawned == True;
		}
		else{
			batSpawned == False;
		}
	
	}

	Void IEnumerator SpawnBat(floast time, Rigidbody bat){
		yield return new WaitForSeconds(time);
			Instantiate(battery, spawnPoint.position, spawnPoint.rotation);
	
		


	} 
}
