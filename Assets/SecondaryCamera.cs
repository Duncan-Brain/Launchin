using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryCamera : MonoBehaviour {

    public Camera primaryCamera;
    private Camera secondaryCamera;

	// Use this for initialization
	void Start () {
        secondaryCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        bool secondary = GvrControllerInput.AppButtonDown;
        if (secondary) {
            //secondaryCamera.enabled = !secondaryCamera.enabled;
            primaryCamera.enabled = !primaryCamera.enabled;
        }
	}
}
