using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

	//public Button button;
	//private ColorBlock theColor;

	public GUIStyle mystyle;

	public Texture2D textureToDisplay;
	float P1_timeRemaining, P2_timeRemaining;
	int P1_minutes, P1_seconds, P2_minutes, P2_seconds;

	public CountDownTimer() {
		P1_timeRemaining = 2700;
		P1_minutes = (int)P1_timeRemaining / 60;
		P1_seconds = (int)P1_timeRemaining % 60;

		P2_timeRemaining = 2700;
		P2_minutes = (int)P2_timeRemaining / 60;
		P2_seconds = (int)P2_timeRemaining % 60;
	}


	// Use this for initialization
	void Start () {
		

		//button1.GetComponentInChildren<Text>().text = "la di da";
	}

	// Update is called once per frame
	void Update () {

		if (!TimerManager.timerManager.isPaused) {
			if (TimerManager.timerManager.isMyTurn == true) {
				P1_timeRemaining -= Time.deltaTime;
				P1_minutes = (int)P1_timeRemaining / 60;
				P1_seconds = (int)P1_timeRemaining % 60;
			}
			if(TimerManager.timerManager.isMyTurn == false) {
				P2_timeRemaining -= Time.deltaTime;
				P2_minutes = (int)P2_timeRemaining / 60;
				P2_seconds = (int)P2_timeRemaining % 60;
			}
		}
	}
		

	void OnGUI() {
		//GUI.color = Color.grey;
		//GUI.backgroundColor = Color.red;
		//GUI.Button (new Rect (100, 100, 100, 30), "Lock Cube");
		//button = GetComponent<Button> ();
		//theColor = GetComponent<Button>().colors;
		//theColor.normalColor = Color.red;

		GUIUtility.RotateAroundPivot(90, new Vector2(100, 200));

		if (P1_timeRemaining > 0) {
			if (P1_seconds >= 10) {
				GUI.Label (new Rect (100, 200, 200, 100), "Time Remaining : " 
					+ P1_minutes + ":" + P1_seconds, mystyle);
			} 
			else {
				GUI.Label (new Rect (100, 200, 200, 100), "Time Remaining : " 
					+ P1_minutes + ":0" + P1_seconds, mystyle);
			}
		} 
		else {
			GUI.Label (new Rect (100, 200, 200, 100), "Time's up", mystyle);
		}

		//GUIUtility.RotateAroundPivot(-90, new Vector2(400, 200));

		if (P2_timeRemaining > 0) {
			if (P2_seconds >= 10) {
				GUI.Label (new Rect (400, 200, 200, 100), "Time Remaining : " 
					+ P2_minutes + ":" + P2_seconds, mystyle);

			} 
			else {
				GUI.Label (new Rect (400, 200, 200, 100), "Time Remaining : " 
					+ P2_minutes + ":0" + P2_seconds, mystyle);
			}
		} 
		else {
			GUI.Label (new Rect (400, 200, 200, 100), "Time's up", mystyle);
		}
	}
}
/*





public class CountDownTimer : MonoBehaviour {
	
	private static CountDownTimer CDTInstance;

	public static CountDownTimer countDownTimer{
		get{ return CountDownTimer.CDTInstance; }
	}

	float x, y, height, width;

	public CountDownTimer (float x, float y, float height, float width) {
		x = this.x;
		y = this.y;
		height = this.height;
		width = this.width;
	}

	float timeRemaining = 2700;
	int minutes;
	int seconds;
	public Texture2D textureToDisplay;
	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!TimerManager.timerManager.isPaused) {
			timeRemaining -= Time.deltaTime;
			minutes = (int)timeRemaining / 60;
			seconds = (int)timeRemaining % 60;
		}
	}

	//Player1 player1 = new Player1 (minutes, seconds, timeRemaining);

	void OnGUI() {
		if (timeRemaining > 0) {
			if (seconds >= 10) {
				GUI.Label (new Rect (x, y, width, height), "Time Remaining : " + minutes + ":" + seconds);
			} 
			else {
				GUI.Label (new Rect (x, y, width, height), "Time Remaining : " + minutes + ":0" + seconds);
			}
		} 
		else {
			GUI.Label (new Rect (x, y, width, height), "Time's up");
		}
	}

	/*
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
}*/
