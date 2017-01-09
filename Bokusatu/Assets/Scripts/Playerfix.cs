using UnityEngine;
using System.Collections;

public class Playerfix : MonoBehaviour {
	Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = pos;
	}
}
