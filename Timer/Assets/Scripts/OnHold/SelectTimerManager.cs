using UnityEngine;
using System.Collections;

public class SelectTimerManager : MonoBehaviour {

	public string strHours, strMinutes, strSeconds;
	GUIStyle number;

	public SelectTimerManager() {
		//strHours = "00 : ";
		//strMinutes = "00 : ";
		//strSeconds = "00 : ";
	}

	public static SelectTimerManager stmInstance;

	public static SelectTimerManager stmManager {
		get { 
			if (stmInstance == null) {
				stmInstance = GameObject.FindObjectOfType<SelectTimerManager> ();
			}
			return SelectTimerManager.stmInstance;
		}

	}
	/*
	public string isClicked() {
		if (GUI.Button (new Rect (240, 60, 80, 50), strHours, number)) {
			return "hours";
		} else if (GUI.Button (new Rect (340, 60, 80, 50), strMinutes, number)) {
			return "minutes";
		} else if (GUI.Button (new Rect (440, 60, 80, 50), strSeconds, number)) {
			return "seconds";
		} else {
			return "error";
		}
	}*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
