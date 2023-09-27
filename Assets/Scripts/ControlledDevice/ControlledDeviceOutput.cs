using UnityEngine;

namespace Born.InterviewTest.ControlledDevice
{
    public class ControlledDeviceOutput : MonoBehaviour
    {
        private DeviceController deviceController;


        private void Start()
        {
            deviceController = FindObjectOfType<DeviceController>();
        }

        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            // Get the current rotation data from the DeviceController
            RotationData currentRotationData = deviceController.GetRotationData();

            // Apply the rotation to the object's transform
            Quaternion rotation = Quaternion.Euler(currentRotationData.xRotation, currentRotationData.yRotation, currentRotationData.zRotation);
            transform.rotation = rotation;
        }
    }
}