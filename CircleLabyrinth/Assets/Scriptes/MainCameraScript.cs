﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{	
	void Update ()
    {
        transform.position -= new Vector3(0, Time.deltaTime/3, 0);
	}
}
