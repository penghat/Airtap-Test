using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class HoloTapToChange : MonoBehaviour, IInputClickHandler, IFocusable {

	public void OnInputClicked(InputClickedEventData eventData) {
		Debug.Log ("Clicked!");
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}

	public void OnFocusEnter() {
		transform.localScale *= 1.2f; // enlarge cube while gazed at
	}
	public void OnFocusExit() {
		transform.localScale /= 1.2f; // shrink cube while gazed at
	}

}