﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenBlocks : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
