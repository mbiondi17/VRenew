using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float dx = Input.GetAxis("Mouse X");
        float dy = Input.GetAxis("Mouse Y");

        Look(new Vector3(dx, dy, 0.0f) * 1.25f);
	}

    void Look(Vector3 newDir)
    {
        Vector3 angles = transform.eulerAngles;
        angles += new Vector3(-newDir.y, newDir.x, newDir.z);
        transform.eulerAngles = new Vector3(angles.x, angles.y, angles.z);
    }
}
