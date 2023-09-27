using UnityEngine;

namespace Born.InterviewTest.App
{
    public class AppEntry : MonoBehaviour
    {
        private App app;

        //[SerializeField] private GameObject trackedBodyPrefab; // Reference to the TrackedBody prefab.

        private void Awake()
        {
            app = new App();


            DontDestroyOnLoad(this);
        }
    }
}
