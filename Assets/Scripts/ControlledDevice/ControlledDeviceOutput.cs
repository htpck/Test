using UnityEngine;

namespace Born.InterviewTest.ControlledDevice
{
    /// <summary>
    /// Turns the attached object into an actual representation of the controlled device.
    /// This needs to apply the rotation value retrieved from the device to the attached object so that we can observe
    /// the device rotation on the scene.
    /// </summary>
    public class ControlledDeviceOutput : MonoBehaviour
    {
        private DeviceController deviceController;

        private void Start()
        {
            // Get the DeviceController component.
            deviceController = GetComponentInParent<DeviceController>();
        }

        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            if (deviceController != null)
            {
                // Get the rotation data from the device controller.
                Quaternion rotationData = deviceController.GetRotationData();

                // Apply the rotation data to the ControlledDeviceOutput object.
                transform.rotation = rotationData;
            }
        }
    }
}
