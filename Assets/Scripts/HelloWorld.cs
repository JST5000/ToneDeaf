using System.Collections;
using System.Collections.Generic;
using System.Threading;
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



    

    // Update is called once per frame
    public void PlayANote(string s)
    {
        float transpose = -4;  // transpose in semitones
        var note = -1; // invalid value to detect when note is pressed
        if (s.Equals("C")) note = 0;  // C

        if (note >= 0)
        { // if some key pressed...
            //AudioClip Clip = (AudioClip)Resources.Load("Assets//Scripts//middle_c.mp3");
            //AudioSource midC = GetComponent<AudioSource>();
            GetComponent<AudioSource>().pitch = Mathf.Pow(2, (0f + transpose) / 12.0f);
            GetComponent<AudioSource>().Play();
			Debug.Log ("Played once");
            Thread.Sleep(1000);
            GetComponent<AudioSource>().Stop();
            Thread.Sleep(300);
            GetComponent<AudioSource>().pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
            GetComponent<AudioSource>().Play();
            Thread.Sleep(1000);
            GetComponent<AudioSource>().Stop();
        }
		Debug.Log ("Finished");
    }

    enum Note { C, Db, D, Eb, F, Gb, G, Ab, A, Bb, B };





}
