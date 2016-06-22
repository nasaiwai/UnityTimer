using UnityEngine;
using System.Collections;

public class SelectNumbers : MonoBehaviour {

	public GUIStyle number;
	public int picked_number;
	public int count;

	private static SelectNumbers selectNumbersInstance;

	public static SelectNumbers selectNumbers {
		get { 
			if (selectNumbersInstance == null) {
				selectNumbersInstance = GameObject.FindObjectOfType<SelectNumbers> ();
			}
			return SelectNumbers.selectNumbersInstance;
		}
	}


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= 2) {
			count = 0;
		}
	}

	public int getNumber() {
		return picked_number;
	}

	int SecondDigits(int number) {
		return 10 * number;
	}

	private void pickedTime(int time) {
		if (count == 0) {
			picked_number = time;
			count++;
		} else if (count == 1) {
			picked_number = SecondDigits (picked_number) + time;
			count++;
		} else {
			picked_number = 0;
			count = 0;
		}
	}

	void OnGUI() {
		GUI.color = Color.white;

		if (GUI.Button (new Rect (240, 105, 80, 25), "1")) {
			pickedTime (1);
		} else if (GUI.Button (new Rect (330, 105, 80, 25), "2")) {
			pickedTime (2);
		} else if (GUI.Button (new Rect (420, 105, 80, 25), "3")) {
			pickedTime (3);
		} else if (GUI.Button (new Rect (240, 135, 80, 25), "4")) {
			pickedTime (4);
		} else if (GUI.Button (new Rect (330, 135, 80, 25), "5")) {
			pickedTime (5);
		} else if (GUI.Button (new Rect (420, 135, 80, 25), "6")) {
			pickedTime (6);
		} else if (GUI.Button (new Rect (240, 165, 80, 25), "7")) {
			pickedTime (7);
		} else if (GUI.Button (new Rect (330, 165, 80, 25), "8")) {
			pickedTime (8);
		} else if (GUI.Button (new Rect (420, 165, 80, 25), "9")) {
			pickedTime (9);
		} else if (GUI.Button (new Rect (240, 195, 80, 25), "Erase")) {
			picked_number = 0;
			count = 0;
		} else if (GUI.Button (new Rect (330, 195, 80, 25), "0")) {
			pickedTime (0);
		}
		if (picked_number >= 2) {
			
		}
		GUI.Button (new Rect (420, 195, 80, 25), "Next");
	}

}
