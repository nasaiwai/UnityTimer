using UnityEngine;
using System.Collections;

public class TimerManager : MonoBehaviour {

	private bool paused;
	private bool ismyturn;

	public TimerManager() {
		paused = true;
	}

	public bool isPaused {
		get { return paused; } 
	}

	public bool isMyTurn {
		get { return ismyturn; }
	}


	private static TimerManager timerInstance;

	public static TimerManager timerManager {
		get { 
			if (timerInstance == null) {
				timerInstance = GameObject.FindObjectOfType<TimerManager> ();
			}
			return TimerManager.timerInstance;
		}
	}

	public void pauseTimer() {
		paused = !paused;
	}

	public void startTimer() {
		paused = false;
	}

	public void switchTurn() {
		ismyturn = !ismyturn;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.P)) {
			pauseTimer ();
		}
	}
}
