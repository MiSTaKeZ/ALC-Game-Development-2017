using UnityEngine;
using System.Collections;

public class Followcam : MonoBehaviour {
	public Transform target;
	public Vector3 defaultDistance = new Vector3(-1.46f, 2f, -4.73f);
	public float distanceDamp = 10f;
	public float rotatinalDamp = 10f;

	Transform myT;

	void Awake(){
		myT = transform;
	}
    
	 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 toPos = target.position + (target.rotation * defaultDistance);
		Vector3 curPos = Vector3.Lerp(myT.position, toPos, distanceDamp * Time.deltaTime);
		myT.position = curPos;

		Quaternion toRot = Quaternion.LookRotation(target.position - myT.position, target.up);
		Quaternion curRot = Quaternion.Slerp(myT.rotation, toRot, rotatinalDamp * Time.deltaTime);
		myT.rotation = curRot;

	}
}
