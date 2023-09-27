using UnityEngine;
using Born.InterviewTest.BodyTracking;

namespace Born.InterviewTest.App
{
    public class AppEntry : MonoBehaviour
    {
        private App app;
        [SerializeField] private GameObject trackedBodyPrefab;

        private void Awake()
        {
            app = new App();

            DontDestroyOnLoad(this);
        }
        private void Start()
        {
            //OBJECTIVE 1: Instantiate the TrackedBody prefab as a child of this GameObject
            GameObject trackedBodyObject = Instantiate(trackedBodyPrefab, transform.position, Quaternion.identity, transform);


            TrackedBody trackedBody = trackedBodyObject.GetComponent<TrackedBody>();

            // OBJECTIVE 2: Provide access to the TrackedBody in the App
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
