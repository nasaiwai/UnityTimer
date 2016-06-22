using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;


public class ConnectScenes : MonoBehaviour {

	public string hours, minutes, seconds, repeat;
	// Use this for initialization
	void Start () {
		//hours = ApplicationLevel.strHours;
		//minutes = ApplicationLevel.strMinutes;
		//seconds = ApplicationLevel.strSeconds;
		//repeat = ApplicationLevel.repeat.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (240, 5, 125, 25), "Cancel")) {
			SceneManager.LoadScene (1);
		} else if (GUI.Button (new Rect (375, 5, 125, 25), "Done")) {
			ApplicationLevel.hours.Add (ApplicationLevel.strHours);
			ApplicationLevel.minutes.Add (ApplicationLevel.strMinutes);
			ApplicationLevel.seconds.Add (ApplicationLevel.strSeconds);
			ApplicationLevel.repeats.Add (ApplicationLevel.repeat.ToString());
			ApplicationLevel.timers.Add (Int32.Parse(ApplicationLevel.strHours) * 3600 
				+ Int32.Parse(ApplicationLevel.strMinutes) * 60 
				+ Int32.Parse(ApplicationLevel.strSeconds));
			//Debug.Log (ApplicationLevel.timers.Count);
			SceneManager.LoadScene (1);
		}
	}
}
