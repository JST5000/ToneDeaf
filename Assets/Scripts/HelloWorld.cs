using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void helloWorld() {
		Debug.Log("Hello World!");
	}

	public void helloWorld(string s) {
		Debug.Log("Hello World! - " + s);
	}

}
