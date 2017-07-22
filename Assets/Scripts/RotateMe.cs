// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float TurnRate = 90f;
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * TurnRate);
    }
}
