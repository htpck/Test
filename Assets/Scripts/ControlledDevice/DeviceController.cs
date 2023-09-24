using UnityEngine;

namespace Born.InterviewTest.ControlledDevice
{
    public class DeviceController : MonoBehaviour
    {
        private Quaternion rotationData = Quaternion.identity;

        // Update the rotation data (simulated communication).
        public void UpdateRotationData(Quaternion newRotation)
        {
            rotationData = newRotation;
        }

        // Get the rotation data.
        public Quaternion GetRotationData()
        {
            return rotationData;
        }
    }
}
