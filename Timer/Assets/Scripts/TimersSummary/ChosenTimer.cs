using UnityEngine;
using System.Collections;
using System;


public class ChosenTimer : MonoBehaviour {

	public GUIStyle mystyle, repeatDisplay;
	public string hours, minutes, seconds, repeat;
	public int y;

	// Use this for initialization
	void Start () {
		hours = ApplicationLevel.strHours;
		minutes = ApplicationLevel.strMinutes;
		seconds = ApplicationLevel.strSeconds;
		repeat = ApplicationLevel.repeat.ToString();
		y = 35;
	}
	
	// Update is called once per frame
	void Update () {
	}	

	void OnGUI() {
		for (int i = 0; i < ApplicationLevel.timers.Count; i++) {
			y = 35 + 50 * i;
			Debug.Log ("i value is " + i);
			if (Int32.Parse(ApplicationLevel.hours[i]) > 0) {
				GUI.Button (new Rect (200, y, 300, 50), " " + ApplicationLevel.hours[i] 
					+ ":" + ApplicationLevel.minutes[i] + ":" + ApplicationLevel.seconds[i] 
					+ "  " + ApplicationLevel.repeats[i] + "times", mystyle);
				Debug.Log ("y value is " + y);
			} else {
				GUI.Button (new Rect (200, y, 300, 50), ApplicationLevel.minutes[i] + ":" 
					+ ApplicationLevel.seconds[i] + "  " + ApplicationLevel.repeats[i] 
					+ "times", mystyle);
				Debug.Log ("y value is " + y);
			}
			Debug.Log (ApplicationLevel.timers.Count);
		}
	}
}
