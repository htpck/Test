using UnityEngine;

//OBJECTIVE 4: Reflective structure

namespace Born.InterviewTest
{
    public class DeviceController : MonoBehaviour
    {
        private RotationData rotationData = new RotationData();

        // Function to update the rotation data
        public void UpdateRotationData(RotationData newRotationData)
        {
            rotationData = newRotationData;
        }

        // Function to get the current rotation data
        public RotationData GetRotationData()
        {
            return rotationData;
        }
    }
}
