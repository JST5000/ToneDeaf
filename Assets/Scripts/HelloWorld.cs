using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HelloWorld : MonoBehaviour {



    public static bool Guessing = false;
    public static string LastNote = "GG";
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
        if (!Guessing)
        {
            float transpose = -4;  // transpose in semitones
            var note = 0; // invalid value to detect when note is pressed
            if (s.Equals("C")) note = 0;  // C
            if (s.Equals("D")) note = 2;  // D
            if (s.Equals("E")) note = 4;  // E
            if (s.Equals("F")) note = 5;  // F
            if (s.Equals("G")) note = 7;  // G
            if (s.Equals("A")) note = 9;  // A
            if (s.Equals("B")) note = 11; // B
            if (note >= 0)
            { // if some key pressed...
              //AudioClip Clip = (AudioClip)Resources.Load("Assets//Scripts//middle_c.mp3");
              //AudioSource midC = GetComponent<AudioSource>();
              //GetComponent<AudioSource>().pitch = Mathf.Pow(2, (0f + transpose) / 12.0f);
              // GetComponent<AudioSource>().Play(0);
                Debug.Log("Played once");
                //Thread.Sleep(3000);
                //GetComponent<AudioSource>().Stop();
                Thread.Sleep(300);
                GetComponent<AudioSource>().pitch = Mathf.Pow(2, (note + transpose) / 12.0f);
                GetComponent<AudioSource>().Play(0);
                Thread.Sleep(3000);
                //GetComponent<AudioSource>().Stop();
            }
            LastNote = s;
            Debug.Log("Finished");
        } else
        {
            if (s.Equals(LastNote)) Debug.Log("YASSSSS");
            else Debug.Log("FAIL");
        }

        Guessing = !Guessing;
    }

    enum Note { C, Db, D, Eb, F, Gb, G, Ab, A, Bb, B };





}
