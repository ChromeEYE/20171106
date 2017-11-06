using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody Prb;
    Transform camrotate;
    float x, y, z;
    float h,hBaff;

	// Use this for initialization
	void Start ()
    {
        Prb = GetComponent<Rigidbody>();
        camrotate = GameObject.Find("GameObject").transform;   		
	}
	
	// Update is called once per frame
	void Update ()
    {
        x = transform.rotation.x; y = transform.rotation.y; z = transform.rotation.z;
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        camrotate.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);

        transform.Translate(Input.GetAxis("Horizontal")/10, 0, Input.GetAxis("Vertical")/10);

        Debug.Log(camrotate.eulerAngles);
	}
}
