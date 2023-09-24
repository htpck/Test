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
            Born.InterviewTest.BodyTracking.Joint desiredJoint = Born.InterviewTest.BodyTracking.Joint.Head;
            // Get the TrackedBody instance from the App class.
            TrackedBody trackedBody = App.App.Instance.TrackedBodyInstance;

            if (trackedBody != null)
            {
                // Calculate the rotation needed to face the head joint.
                Vector3 directionToHead = trackedBody.GetJointPose(desiredJoint).position - transform.position;
                Quaternion rotationToHead = Quaternion.LookRotation(directionToHead);

                // Apply the rotation to the ControlledDeviceInput object.
                transform.rotation = rotationToHead;
            }
        }
    }
}
