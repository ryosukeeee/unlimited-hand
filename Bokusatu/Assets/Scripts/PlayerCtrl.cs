using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w")) {
			transform.position += transform.forward * speed;
		
		} else if (Input.GetKey ("d")) {
			transform.Rotate (0, 5, 0);
		} else if (Input.GetKey ("a")) {
			transform.Rotate (0, -5, 0);
		}

	
	}
}
