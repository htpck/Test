using UnityEngine;

namespace Born.InterviewTest.BodyTracking
{
    /// <summary>
    /// Represents a tracked body.
    /// For the purpose of this test, Head, Left Hand, and Right Hand joints are wired on the editor.
    /// Tracking would simulated by merely moving these objects in the scene on Unity editor.
    /// </summary>
    public class TrackedBody : MonoBehaviour
    {
        [SerializeField] private Transform head;
        [SerializeField] private Transform rightHand;
        [SerializeField] private Transform leftHand;

        /// <summary>
        /// Returns the Pose of a joint of this TrackedBody in world space.
        /// </summary>
        /// <param name="joint">The joint whose Pose is being requested.</param>
        /// <returns>A Pose value containing the joints position and rotation in world space.</returns>
        public Pose GetJointPose(Joint joint)
        {
            switch (joint)
            {
                case Joint.Head:
                    return new Pose(head.position, head.rotation);
                
                case Joint.HandRight:
                    return new Pose(rightHand.position, rightHand.rotation);

                case Joint.HandLeft:
                    return new Pose(leftHand.position, leftHand.rotation);
            }

            return new Pose(Vector3.zero, Quaternion.identity);
        }
    }
}
