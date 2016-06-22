using UnityEngine;
using System.Collections;

public class Repeat : MonoBehaviour {

	public GUIStyle mystyle, check, clicked;
	public Texture right_arrow, left_arrow;
	private bool isclicked;
	//public int times;

	private static Repeat repeatInstance;

	public static Repeat repeat {
		get {
			if (repeatInstance == null) {
				repeatInstance = GameObject.FindObjectOfType<Repeat> ();
			}
			return Repeat.repeatInstance;
		}
	}


	// Use this for initialization
	void Start () {
		isclicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ApplicationLevel.repeat == -1) {
			ApplicationLevel.repeat = 15;
		}
		if (ApplicationLevel.repeat == 16) {
			ApplicationLevel.repeat = 0;
		}	
	}

	public int Repeated() {
		return ApplicationLevel.repeat;
	}

	bool isClicked() {
		return isclicked;
	}	

	void OnGUI() {
		GUI.Button (new Rect (300, 235, 50, 25), "Repeat", mystyle);
		GUI.Button (new Rect (380, 230, 40, 30), ApplicationLevel.repeat.ToString());
		GUI.Button (new Rect (455, 235, 80, 25), "times", mystyle);
		if (GUI.Button (new Rect (350, 230, 40, 30), left_arrow, mystyle)) {
			ApplicationLevel.repeat--;
		}
		if (GUI.Button (new Rect (427, 230, 40, 30), right_arrow, mystyle)) {
			ApplicationLevel.repeat++;
		}

		if (GUI.Button (new Rect (270, 232, 25, 25), "", check)) {
			isclicked = !isclicked;
		}
		if (isclicked == true) {
			GUI.Button (new Rect (270, 232, 25, 25), "", clicked);
		}
	}
}
