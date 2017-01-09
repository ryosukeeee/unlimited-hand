using UnityEngine;
using System.Collections;
using System;

public class Test : MonoBehaviour {

	// Use this for initialization
	public UH uhand;


	void Start () {
		
	
	}

	// Update is called once per frame
	void Update () {

//		
//		transform.rotation = new Quaternion (quaternion[0], 
//		quaternion[1], 
//		quaternion[3],
//		quaternion[2]); 

		transform.rotation = new Quaternion (uhand.UHQuaternion[0], 
		uhand.UHQuaternion[1], 
		uhand.UHQuaternion[3],
			uhand.UHQuaternion[2]); 
			
	}
}
