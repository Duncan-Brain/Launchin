using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRocket : MonoBehaviour {

    private bool started = false;
    private float velocity = 0f;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (GvrControllerInput.ClickButtonDown) { // deprecated but i dgaf
            started = true;
        }

        if (!started) {
            return;
        }

        velocity += Time.deltaTime * 2;

        transform.position += transform.up * velocity * Time.deltaTime;
	}
}
