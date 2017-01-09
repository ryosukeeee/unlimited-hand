using UnityEngine;
using System.Collections;
using System;
using System.Threading;

public class feedback : MonoBehaviour {
	[SerializeField]
	public UH hand;



	// Use this for initialization
	void Start () {
		//uhand.setVoltageLevelUp();

	}
	void OnCollisionEnter(Collision collision){
		Debug.Log ("hit");
		//hand.setVoltageLevelUp();
		//hand.vibrate ();
		hand.stimulateSetSleepTime (1, 100);
		hand.stimulate (1);

	}
	// Update is called once per frame
	void Update () {
	
	}
}
