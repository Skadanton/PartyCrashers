﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
	}
}
