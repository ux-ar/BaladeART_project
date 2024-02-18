using System.Collections;
using System.Collections.Generic;
using Google.XR.ARCoreExtensions;
using TMPro;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
#if UNITY_ANDROID
using UnityEngine.Android;
#endif
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class GeospatialManager : MonoBehaviour
{
    [Header("Core Features")]

    [SerializeField]
    public AREarthManager earthManager;

    [SerializeField]
    public ARCoreExtensions arcoreExtensions;

    public bool waitingForLocationService = false;

    public Coroutine locationServiceLauncher;

    public void Awake()
    {
        // Enable geospatial sample to target 60fps camera capture frame rate
        // on supported devices.
        // Note, Application.targetFrameRate is ignored when QualitySettings.vSyncCount != 0.
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (!Debug.isDebugBuild || earthManager == null)
        {
            return;
        }

        if (ARSession.state != ARSessionState.SessionInitializing &&
               ARSession.state != ARSessionState.SessionTracking)
        {
            return;
        }

        // Check feature support and enable Geospatial API when it's supported.
        var featureSupport = earthManager.IsGeospatialModeSupported(GeospatialMode.Enabled);
        switch (featureSupport)
        {
            case FeatureSupported.Unknown:
                break;
            case FeatureSupported.Unsupported:
                Debug.Log("The Geospatial API is not supported by this device.");
                break;
            case FeatureSupported.Supported:
                if (arcoreExtensions.ARCoreExtensionsConfig.GeospatialMode == GeospatialMode.Disabled)
                {
                    arcoreExtensions.ARCoreExtensionsConfig.GeospatialMode =
                        GeospatialMode.Enabled;
                    arcoreExtensions.ARCoreExtensionsConfig.StreetscapeGeometryMode =
                        StreetscapeGeometryMode.Enabled;
                }
                break;
        }

        var pose = earthManager.EarthState == EarthState.Enabled &&
            earthManager.EarthTrackingState == TrackingState.Tracking ?
            earthManager.CameraGeospatialPose : new GeospatialPose();
        var supported = earthManager.IsGeospatialModeSupported(GeospatialMode.Enabled);


    }

    private void OnEnable()
    {
        locationServiceLauncher = StartCoroutine(StartLocationService());
    }

    public void OnDisable()
    {
        StopCoroutine(locationServiceLauncher);
        locationServiceLauncher = null;
        Debug.Log("Stopping location services.");
        Input.location.Stop();
    }

    public IEnumerator StartLocationService()
    {
        waitingForLocationService = true;

#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
        {
            Debug.Log("Requesting the fine location permission.");
            Permission.RequestUserPermission(Permission.FineLocation);
            yield return new WaitForSeconds(3.0f);
        }
#endif

        if (!Input.location.isEnabledByUser)
        {
            waitingForLocationService = false;
            yield break;
        }

        Debug.Log("Starting location service.");
        Input.location.Start();

        while (Input.location.status == LocationServiceStatus.Initializing)
        {
            yield return null;
        }

        waitingForLocationService = false;
        if (Input.location.status != LocationServiceStatus.Running)
        {
            Debug.Log($"Location service ended with {0} status {Input.location.status}");
            Input.location.Stop();
        }
    }
}