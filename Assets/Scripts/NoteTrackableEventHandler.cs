// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections;
using UnityEngine;

namespace Vuforia
{    
    public class NoteTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
    {
        public GameObject ARPanelObject;
        public TextMesh HUDTextMesh;

        private TrackableBehaviour mTrackableBehaviour;
       
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }

            if (ARPanelObject)
            {
                ARPanelObject.transform.gameObject.SetActive(false);
            }
        }

        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        private void OnTrackingFound()
        {            
            if (ARPanelObject != null)
            {
                ARPanelObject.transform.position = transform.position;
                ARPanelObject.transform.rotation = transform.rotation;
                ARPanelObject.SetActive(true);

                VuforiaBehaviour.Instance.enabled = false;
                HUDTextMesh.gameObject.SetActive(false);
            }
        }


        private void OnTrackingLost()
        {
            // TODO: Marker Handle Tracking Lost
        }        
    }    
}
