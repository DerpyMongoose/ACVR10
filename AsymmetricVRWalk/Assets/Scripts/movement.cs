﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey("w"))
        {
            transform.position -= new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0, 0, 0.05f);
        }
        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(0, 0, 0.05f);
        }
    }
}
