﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text displayText;

	[HideInInspector] public RoomNavigation roomNavigation;

	List<string> actionLog = new List<string>();

	// Use this for initialization
	void Awake () {
		roomNavigation = GetComponent<RoomNavigation> ();
	}

	void Start() {
		DisplayRoomText ();
		DisplayLoggedText ();
	}

	public void DisplayLoggedText() {
		string logAsText = string.Join ("\n", actionLog.ToArray ());

		displayText.text = logAsText;
	}


	public void DisplayRoomText() {
		string combinedText = roomNavigation.currentRoom.description + "\n";

		LogStringWithReturn (combinedText);
	}

	public void LogStringWithReturn(string stringToAdd) {
		actionLog.Add (stringToAdd + "\n");
	}

}
