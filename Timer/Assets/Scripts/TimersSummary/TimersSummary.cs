using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class TimersSummary : MonoBehaviour {

	public GUIStyle mystyle;
	public Texture options;
	public string hours, minutes, seconds, repeat;

	// Use this for initialization
	void Start () {
		hours = ApplicationLevel.strHours;
		minutes = ApplicationLevel.strMinutes;
		seconds = ApplicationLevel.strSeconds;
		repeat = ApplicationLevel.repeat.ToString();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (400, 5, 25, 25), "+")) {
			SceneManager.LoadScene (2);
		}
		if (GUI.Button (new Rect (640, 20, 25, 25), options, mystyle)) {
			SceneManager.LoadScene (0);
		}
	}
}
