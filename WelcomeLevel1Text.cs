﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeLevel1Text : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Destroy(gameObject);
        }
    }
}
