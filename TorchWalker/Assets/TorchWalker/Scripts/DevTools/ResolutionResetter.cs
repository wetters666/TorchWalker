﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionResetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Screen.SetResolution(960, 540, false);
	}
}
