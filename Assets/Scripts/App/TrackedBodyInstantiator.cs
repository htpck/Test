using UnityEngine;
using Born.InterviewTest.BodyTracking;

namespace Born.InterviewTest.App
{
    public class TrackedBodyInstantiator : MonoBehaviour
    {
        [SerializeField] private GameObject trackedBodyPrefab;

        private void Start()
        {
            // Instantiate the TrackedBody prefab as a child of this GameObject
            GameObject trackedBodyObject = Instantiate(trackedBodyPrefab, transform.position, Quaternion.identity, transform);

            // Get the TrackedBody component
            TrackedBody trackedBody = trackedBodyObject.GetComponent<TrackedBody>();

            // Provide access to the TrackedBody in the App
            if (App.Instance != null)
            {
                App.Instance.SetTrackedBody(trackedBody);
            }
            else
            {
                Debug.LogError("App.Instance is null. Make sure AppEntry is properly set up.");
            }
        }
    }
}
