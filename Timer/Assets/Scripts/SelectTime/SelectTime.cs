using UnityEngine;
using System.Collections;

using System;
using System.Linq;
using System.Collections.Generic;

public class SelectTime : MonoBehaviour {

	public GUIStyle mystyle;
	public GUIStyle number;
	public GUIStyle black;

	//public string strHours, strMinutes, strSeconds, selectedTime;

	public Texture2D textureToDisplay;

	public int hms;
	int time;
	private bool isHourClicked, isMinuteClicked, isSecondClicked;

	private static SelectTime selectTimeInstance;

	public static SelectTime selectTime {
		get { 
			if (selectTimeInstance == null) {
				selectTimeInstance = GameObject.FindObjectOfType<SelectTime> ();
			}
			return SelectTime.selectTimeInstance;
		}
	}

	public SelectTime() {
		hms = 1;
	}

	// Use this for initialization
	void Start () {
	}

	void Update () {
		time = SelectNumbers.selectNumbers.getNumber();
	}

	void OnGUI() {

		GUI.Label (new Rect (255, 35, 200, 100), "Hours", mystyle);
		GUI.Label (new Rect (342, 35, 200, 100), "Minutes", mystyle);
		GUI.Label (new Rect (437, 35, 200, 100), "Seconds", mystyle);

		GUI.Button (new Rect (310, 50, 10, 50), ":", black);
		GUI.Button (new Rect (415, 50, 10, 50), ":", black);

		if (GUI.Button (new Rect (240, 50, 80, 50), ApplicationLevel.strHours, number)) {
			hms = 1;
			SelectNumbers.selectNumbers.picked_number = 0;
		} else if (GUI.Button (new Rect (340, 50, 80, 50), ApplicationLevel.strMinutes, number)) {
			hms = 2;
			SelectNumbers.selectNumbers.picked_number = 0;
		} else if (GUI.Button (new Rect (440, 50, 80, 50), ApplicationLevel.strSeconds, number)) {
			hms = 3;
			SelectNumbers.selectNumbers.picked_number = 0;
		}
	
		if (hms == 1) {
			if (time >= 10) {
				ApplicationLevel.strHours = time.ToString ();
			} else {			
				ApplicationLevel.strHours = "0" + time.ToString ();
			}
		} 
		if (hms == 2) {
			if (time >= 10) {
				ApplicationLevel.strMinutes = time.ToString ();
				if (time >= 60) {
					ApplicationLevel.strMinutes = "59";
				}
			} else {
				ApplicationLevel.strMinutes = "0" + time.ToString ();
			}			
		} 
		if (hms == 3) {
			if (time >= 10) {
				ApplicationLevel.strSeconds = time.ToString ();
				if (time >= 60) {
					ApplicationLevel.strSeconds = "59";
				}
			} else {
				ApplicationLevel.strSeconds = "0" + time.ToString ();
			}
		}
	}
}
	
	// Update is called once per frame
/*	void Update () {
		time = SelectNumbers.selectNumbers.getNumber();

		if(hms == 4) {
			//Debug.Log ("hour number button");
			if (time >= 10) {
				//Debug.Log ("hour time changed");
				strHours = time.ToString ();
			} else {			
				strHours = "0" + time.ToString ();
			}
		}

		if(hms == 2) {
			if (time >= 10) {
				strMinutes = time.ToString ();
				if (time >= 60) {
					strMinutes = "59";
				}
			} else {
				strMinutes = "0" + time.ToString ();
			}
		}

		if(hms == 3) {
			if (time >= 10) {
				strSeconds = time.ToString ();
				if (time >= 60) {
					strSeconds = "59";
				}
			} else {
				strSeconds = "0" + time.ToString ();
			}
		}

	}
		
	void OnGUI() {

		GUI.Label (new Rect (255, 40, 200, 100), "Hours", mystyle);
		GUI.Label (new Rect (342, 40, 200, 100), "Minutes", mystyle);
		GUI.Label (new Rect (437, 40, 200, 100), "Seconds", mystyle);

		GUI.Button (new Rect (310, 60, 80, 50), ":", black);
		GUI.Button (new Rect (415, 60, 80, 50), ":", black);

		if (GUI.Button (new Rect (240, 60, 80, 50), strHours, number)) {
			hms = 4;
			SelectNumbers.selectNumbers.picked_number = 0;
		} else if (GUI.Button (new Rect (340, 60, 80, 50), strMinutes, number)) {
			hms = 2;
			SelectNumbers.selectNumbers.picked_number = 0;
		} else if (GUI.Button (new Rect (440, 60, 80, 50), strSeconds, number)) {
			hms = 3;
			SelectNumbers.selectNumbers.picked_number = 0;
		}
			
	}
}
*/




/*
if (GUI.Button (new Rect (240, 60, 80, 50), strHours, number)) {
	//Debug.Log ("hpur number button");
	hms = 1;
	//Debug.Log ("hms = 1");
	SelectNumbers.selectNumbers.picked_number = 0;
	//SelectNumbers.selectNumbers.picked_number = Int32.Parse(strHours);
	//Debug.Log ("SelectNumbers.selectNumbers.picked_number = 0;");
} else if (GUI.Button (new Rect (340, 60, 80, 50), strMinutes, number)) {
	//Debug.Log ("minute number button");
	hms = 2;
	//Debug.Log ("hms = 2");
	//SelectNumbers.selectNumbers.picked_number = Int32.Parse(strMinutes);
	SelectNumbers.selectNumbers.picked_number = 0;
	//Debug.Log ("SelectNumbers.selectNumbers.picked_number = 0;");
} else if (GUI.Button (new Rect (440, 60, 80, 50), strSeconds, number)) {
	hms = 3;
	//Debug.Log ("hms = 3");
	//SelectNumbers.selectNumbers.picked_number = Int32.Parse(strSeconds);
	SelectNumbers.selectNumbers.picked_number = 0;
	//Debug.Log ("SelectNumbers.selectNumbers.picked_number = 0;");
}*/

/*
	void HourChange() {
		Debug.Log ("hour number button");
			if (time >= 10) {
				Debug.Log ("hour time changed");
				strHours = time.ToString ();
			} else {			
				strHours = "0" + time.ToString ();
			}
	}

	void MinutesChange() {
			if (time >= 10) {
				strMinutes = time.ToString ();
				if (time >= 60) {
					strMinutes = "59";
				}
			} else {
				strMinutes = "0" + time.ToString ();
			}
	}

	void SecondsChange() {
			if (time >= 10) {
				strSeconds = time.ToString ();
				if (time >= 60) {
					strSeconds = "59";
				}
			} else {
				strSeconds = "0" + time.ToString ();
			}
	}*/

/* Minutes Display *//*
GUI.Label (new Rect (342, 40, 200, 100), "Minutes", mystyle);

if (minutes >= 10) {
	if (GUI.Button (new Rect (340, 60, 80, 50), "" + minutes + " : ", number)) {
		minutes = time;
		if (minutes >= 60) {
			minutes = 59;
		}
	}

} 
else {
	if (GUI.Button (new Rect (340, 60, 80, 50), "0" + minutes + " : ", number)) {
		minutes = time;
		if (minutes >= 60) {
			minutes = 59;
		}
	}
}*/

/* Seconds Display */ /*
GUI.Label (new Rect (437, 40, 200, 100), "Seconds", mystyle);

if (seconds >= 10) {
	if (GUI.Button (new Rect (440, 60, 80, 50), "" + seconds, number)) {
		seconds = time;
		if (seconds >= 60) {
			seconds = 59;
		}
	}

} 
else {
	if (GUI.Button (new Rect (440, 60, 80, 50), "0" + seconds, number)) {
		seconds = time;
		if (seconds >= 60) {
			seconds = 59;
		}
	}
}*/