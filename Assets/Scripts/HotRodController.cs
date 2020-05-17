using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class HotRodController : MonoBehaviour {

    public float speed = 10f;
    public float rotationSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float forward = CrossPlatformInputManager.GetAxis("Vertical") * speed;
        float rotate = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;
        forward *= Time.deltaTime;
        rotate *= Time.deltaTime;
        transform.Translate(0, 0, forward);
        transform.Rotate(0, rotate, 0);
		
	}
}
