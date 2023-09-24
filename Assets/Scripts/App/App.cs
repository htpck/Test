using UnityEngine;
using Born.InterviewTest.BodyTracking;


namespace Born.InterviewTest.App
{
    /// <summary>
    /// The class for the application.
    /// This needs to instantiate long running systems and can also be the dependency provider to MonoBehaviour classes.
    /// </summary>
    public class App
    {
        public static App Instance { get; private set; }
        public TrackedBody TrackedBodyInstance { get; private set; }

        public App()
        {
            Instance = this;

            // Instantiate long-running systems here.

            Debug.Log("App started.");
        }
    }
}