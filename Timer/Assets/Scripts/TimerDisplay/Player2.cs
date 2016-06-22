using UnityEngine;
using System.Collections;
using System;

public class Player2 : MonoBehaviour {
	public GUIStyle mystyle;

	public Texture2D textureToDisplay;
	float P2_timeRemaining;
	int P2_hours, P2_minutes, P2_seconds;

	// Use this for initialization
	void Start () {
		P2_timeRemaining = Int32.Parse(ApplicationLevel.strHours) * 3600 
			+ Int32.Parse(ApplicationLevel.strMinutes) * 60 
			+ Int32.Parse(ApplicationLevel.strSeconds);
		P2_hours = (int)P2_timeRemaining / 3600;
		P2_minutes = (int)P2_timeRemaining / 60;
		P2_seconds = (int)P2_timeRemaining % 60;
		//button1.GetComponentInChildren<Text>().text = "la di da";
	}

	// Update is called once per frame
	void Update () {

		if (!TimerManager.timerManager.isPaused) {
			if(TimerManager.timerManager.isMyTurn == true) {
				P2_timeRemaining -= Time.deltaTime;
				P2_hours = (int)P2_timeRemaining / 3600;
				P2_minutes = (int)P2_timeRemaining / 60;
				P2_seconds = (int)P2_timeRemaining % 60;
			}
		}
	}


	void OnGUI() {

		GUIUtility.RotateAroundPivot(90, new Vector2(250, 100));

		if (P2_timeRemaining > 0) {
			if (P2_hours > 0) {
				if (P2_minutes >= 10) {
					if (P2_seconds >= 10) {
						GUI.Label (new Rect (250, 100, 80, 30), P2_hours + ":" 
							+ P2_minutes + ":" + P2_seconds, mystyle);

					} else {
						GUI.Label (new Rect (250, 100, 80, 30), P2_hours + ":" 
							+ P2_minutes + ":0" + P2_seconds, mystyle);
					}
				} else {
					if (P2_seconds >= 10) {
						GUI.Label (new Rect (250, 100, 80, 30), P2_hours + ":0"
							+ P2_minutes + ":" + P2_seconds, mystyle);
					} else {
						GUI.Label (new Rect (250, 100, 80, 30), P2_hours + ":0"
							+ P2_minutes + ":0" + P2_seconds, mystyle);
					}
				}
			} else {
				if (P2_seconds >= 10) {
					GUI.Label (new Rect (250, 100, 80, 30), P2_minutes + ":" + P2_seconds, mystyle);

				} else {
					GUI.Label (new Rect (250, 100, 80, 30), P2_minutes + ":0" + P2_seconds, mystyle);
				}
			}
		} 
		else {
			GUI.Label (new Rect (250, 100, 80, 30), "Time's up", mystyle);
		}
	}
}

/*
if (P2_seconds >= 10) {
	GUI.Label (new Rect (250, 100, 200, 100), P2_minutes + ":" + P2_seconds, mystyle);
} 
else {
	GUI.Label (new Rect (250, 100, 200, 100), P2_minutes + ":0" + P2_seconds, mystyle);
}*/