using UnityEngine;
using Born.InterviewTest.BodyTracking;


namespace Born.InterviewTest.ControlledDevice
{
    public class ControlledDeviceInput : MonoBehaviour
    {
        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            TrackedBody trackedBody = App.App.Instance.GetTrackedBody();
            if (trackedBody != null)
            {
                Vector3 headPosition = trackedBody.GetJointPose(Born.InterviewTest.BodyTracking.Joint.Head).position;

                // Calculate the direction from the current position to the head position
                Vector3 directionToHead = headPosition - transform.position;

                // Ensure that the direction vector is not zero to avoid division by zero
                if (directionToHead != Vector3.zero)
                {
                    // Calculate the rotation needed to point towards the head position
                    Quaternion rotationToHead = Quaternion.LookRotation(directionToHead);

                    // Apply the rotation to the object's transform
                    transform.rotation = rotationToHead;
                }
                else
                { Debug.Log("Tracked Body is null"); }

            }
        }
    }
}
