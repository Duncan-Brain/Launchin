using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckingFollowRocket : MonoBehaviour {

    public GameObject rocket;

    private bool initialized = false;
    private Vector3 initialOffset;
    private Vector3 initialRocketOffset;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!initialized) {
            initialized = true;
            initialOffset = new Vector3(-28, 23, -14);
            initialRocketOffset = rocket.transform.position;
            //Debug.LogError(GetComponent<Camera>().transform.position);
        }

        transform.position = initialOffset + (rocket.transform.position - initialRocketOffset);
	}
}
