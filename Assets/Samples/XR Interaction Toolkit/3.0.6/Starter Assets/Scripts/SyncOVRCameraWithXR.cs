using UnityEngine;

public class SyncOVRCameraWithXR : MonoBehaviour
{
    public Transform xrOrigin; // Assign XR Origin in the Inspector
    public Transform ovrCameraRig; // Assign OVR Camera Rig in the Inspector

    void LateUpdate()
    {
        if (xrOrigin != null && ovrCameraRig != null)
        {
            // Match the OVR Camera Rig's position and rotation to the XR Origin
            ovrCameraRig.position = xrOrigin.position;
            ovrCameraRig.rotation = xrOrigin.rotation;
        }
    }
}
