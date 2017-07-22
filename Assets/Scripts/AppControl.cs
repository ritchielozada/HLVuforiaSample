// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AppControl : MonoBehaviour
{
    public TextMesh HUDStatusText;   

    public void SetVuforiaBehavior(bool status)
    {
        VuforiaBehaviour.Instance.enabled = status;
        if (status)
        {
            HUDStatusText.gameObject.SetActive(true);
            HUDStatusText.text = "Scan for Marker";
        }
        else
        {
            HUDStatusText.text = string.Empty;
            HUDStatusText.gameObject.SetActive(false);
        }
    }
}
