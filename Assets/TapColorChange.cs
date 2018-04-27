using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class TapColorChange : MonoBehaviour {

	GestureRecognizer recognizer;

	void Awake() {
		recognizer = new GestureRecognizer();
		recognizer.SetRecognizableGestures(GestureSettings.Tap);
		recognizer.StartCapturingGestures();
	}

	void OnEnable() {
		recognizer.TappedEvent += Recognizer_TappedEvent;
	}

	void OnDisable() {
		recognizer.TappedEvent -= Recognizer_TappedEvent;
	}

	void Update () {
		// simulate tap with mouse button: NOT NECESSARY FOR HOLOLENS, COULD DELETE ENTIRE METHOD
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("it's click");
			Recognizer_TappedEvent(
				InteractionSourceKind.Other, 1, Camera.main.ScreenPointToRay(Input.mousePosition));
		}
	}

	private void Recognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay) {
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}
}