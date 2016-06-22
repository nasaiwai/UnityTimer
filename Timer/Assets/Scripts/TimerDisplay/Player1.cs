using UnityEngine;
using System.Collections;
using System;

public class Player1 : MonoBehaviour {

	public GUIStyle mystyle;
	public Texture2D textureToDisplay;
	float P1_timeRemaining;
	int P1_hours, P1_minutes, P1_seconds, repeat, i;

	public Player1() {
		//P1_timeRemaining = 2700;

	}


	// Use this for initialization
	void Start () {
		i = 0;
		P1_timeRemaining = ApplicationLevel.timers [i];
		//P1_timeRemaining = Int32.Parse(ApplicationLevel.strHours) * 3600 
		//	+ Int32.Parse(ApplicationLevel.strMinutes) * 60 
		//	+ Int32.Parse(ApplicationLevel.strSeconds);
		P1_hours = (int)P1_timeRemaining / 3600;
		P1_minutes = (int)(P1_timeRemaining - P1_hours * 3600) / 60;
		P1_seconds = (int)P1_timeRemaining % 60;
		repeat = Int32.Parse (ApplicationLevel.repeats[i]);
		//button1.GetComponentInChildren<Text>().text = "la di da";
	}

	// Update is called once per frame
	void Update () {

		if (!TimerManager.timerManager.isPaused) {
			if (TimerManager.timerManager.isMyTurn == false) {
				P1_timeRemaining -= Time.deltaTime;
				P1_hours = (int)P1_timeRemaining / 3600;
				P1_minutes = (int)(P1_timeRemaining - P1_hours * 3600) / 60;
				P1_seconds = (int)P1_timeRemaining % 60;
			}
		}
	}


	void OnGUI() {

		GUIUtility.RotateAroundPivot(-90, new Vector2(500, 220));

		if (P1_timeRemaining > 0) {
			if (P1_hours > 0) {
				if (P1_minutes >= 10) {
					if (P1_seconds >= 10) {
						GUI.Label (new Rect (500, 220, 80, 30), P1_hours + ":" 
							+ P1_minutes + ":" + P1_seconds, mystyle);

					} else {
						GUI.Label (new Rect (500, 220, 80, 30), P1_hours + ":" 
							+ P1_minutes + ":0" + P1_seconds, mystyle);
					}
				} else {
					if (P1_seconds >= 10) {
						GUI.Label (new Rect (500, 220, 80, 30), P1_hours + ":0"
							+ P1_minutes + ":" + P1_seconds, mystyle);
					} else {
						GUI.Label (new Rect (500, 220, 80, 30), P1_hours + ":0"
							+ P1_minutes + ":0" + P1_seconds, mystyle);
					}
				}
			} else {
				if (P1_seconds >= 10) {
					GUI.Label (new Rect (500, 220, 80, 30), P1_minutes + ":" + P1_seconds, mystyle);

				} else {
					GUI.Label (new Rect (500, 220, 80, 30), P1_minutes + ":0" + P1_seconds, mystyle);
				}
			}
		} 
		else {
			if (repeat > 0) {
				P1_timeRemaining = ApplicationLevel.timers [i];
				P1_hours = (int)P1_timeRemaining / 3600;
				P1_minutes = (int)(P1_timeRemaining - P1_hours * 3600) / 60;
				P1_seconds = (int)P1_timeRemaining % 60;
				repeat--;
			} else {
				i++;
				if (i < ApplicationLevel.timers.Count) {
					P1_timeRemaining = ApplicationLevel.timers [i];
					P1_hours = (int)P1_timeRemaining / 3600;
					P1_minutes = (int)(P1_timeRemaining - P1_hours * 3600) / 60;
					P1_seconds = (int)P1_timeRemaining % 60;
				} else {
					GUI.Label (new Rect (500, 220, 80, 30), "00:00", mystyle);
				}
			}
		}
	}
}





/*
	//base.OnGUI();
	
	int minutes, seconds;
	float timeRemaining;

	public Player1(int minutes, int seconds, float timeRemaining) {
		minutes = this.minutes;
		seconds = this.seconds;
		timeRemaining = this.timeRemaining;
	}

	void OnGUI() {
		if (timeRemaining > 0) {
			if (seconds >= 10) {
				GUI.Label (new Rect (200, 200, 200, 100), "Time Remaining : " + minutes + ":" + seconds);
			} 
			else {
				GUI.Label (new Rect (200, 200, 200, 100), "Time Remaining : " + minutes + ":0" + seconds);
			}
		} 
		else {
			GUI.Label (new Rect (200, 200, 200, 100), "Time's up");
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (base.timeRemaining > 0) {
			if (base.seconds >= 10) {
				GUI.Label (new Rect (200, 200, 100, 100), "Time Remaining : " + base.minutes + ":" + base.seconds);
			} 
			else {
				GUI.Label (new Rect (200, 200, 100, 100), "Time Remaining : " + base.minutes + ":0" + base.seconds);
			}
		} 
		else {
			GUI.Label (new Rect (200, 200, 100, 100), "Time's up");
		}
	}
}
*/
