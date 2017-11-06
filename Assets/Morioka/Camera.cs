using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform campos;

	// Use this for initialization
	void Start ()
    {
        campos = GameObject.Find("campos").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = campos.position;
        transform.rotation = campos.rotation;
	}
}
