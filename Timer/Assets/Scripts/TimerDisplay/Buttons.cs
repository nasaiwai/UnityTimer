using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour {

	public GUIStyle mystyle;
	public Texture options;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		if (GUI.Button (new Rect (640, 20, 25, 25), options, mystyle)) {
			SceneManager.LoadScene (1);
		}
	}
}
