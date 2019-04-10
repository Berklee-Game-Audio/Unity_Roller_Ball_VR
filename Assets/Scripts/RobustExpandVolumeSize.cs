using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

//LMSC-281 Logic and Programming
//Team VR Project
//Fall 2018 - Sung Ha Hong

// script manipulated from https://www.youtube.com/watch?v=U-L0COB3lys
// main objective: if either trigger button or Grip button is pressed down,  up-down thumb movement of the OTHER HAND's Trackpad can change volume & size of the sphere
// script done in HTC Vive, not Oculus Rift

public class RobustExpandVolumeSize : MonoBehaviour {

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    public GameObject Pickup;
    //public static float GetAxis(string axisName);

    // Use this for initialization
    void Start() {
        trackedObject = GetComponent<SteamVR_TrackedObject>();

    }

    // Update is called once per frame
    void Update() {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetPressDown(triggerButton)) {
            //Debug.Log("Trigger has been pressed");

            //GetComponent<SteamVR_Controller.ButtonMask.Touchpad.int ulong.CompareTo(object value)> ();

            //declaring the horizontal/up-down movement of the Touchpad of Vive controller to control the parameter of the volume of the Pickup's audio source 
            //Unity Axis Value Range of Trackpad's horizontal movement is by default -1.0 to 1.0 (reference: https://docs.unity3d.com/Manual/OpenVRControllers.html)

            //Pickup.AudioSource.Volume = SteamVR_Controller.ButtonMask.Touchpad.Input.GetAxis("Horizontal");

        }
    }
}
