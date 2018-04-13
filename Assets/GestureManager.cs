using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; // changed from VR.WSA.Input

public class GestureManager : MonoBehaviour {

	public GameObject orangeCubePrefab;
	GestureRecognizer recognizer;

	// Use this for initialization
	void Start () {
		recognizer = new GestureRecognizer ();
		recognizer.TappedEvent += Recognizer_TappedEvent;
		// recognize an airtap then do stuff!
		recognizer.StartCapturingGestures();
	}

	private void Recognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay)
	{
		// headray has Vector3D direction and origin (of hololens) for manipulation
		var direction = headRay.direction;
		var origin = headRay.origin;
		var position = origin + direction * 2.0f; // 2 meters in front of user
		Instantiate(orangeCubePrefab, position, Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
