using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public static GPS Instance { get; private set; }

    public float latitude;
    public float longitude;
    public List<ARObjectData> arObjectDataList;
    public Transform arObjectContainer;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }

    public IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("User has not enabled GPS");
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait <= 0)
        {
            Debug.Log("Timed out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;

        // Verifier pour chaque objet AR si la position est ok
        foreach (ARObjectData arObjectData in arObjectDataList)
        {
            if (IsTargetReached(arObjectData.latitude, arObjectData.longitude))
            {
                InstantiateARObject(arObjectData); // Instancier l'objet AR
            }
        }
    }

    private bool IsTargetReached(float targetLatitude, float targetLongitude)
    {
        float errorMargin = 0.0001f;
        return Mathf.Abs(latitude - targetLatitude) < errorMargin && Mathf.Abs(longitude - targetLongitude) < errorMargin;
    }

    private void InstantiateARObject(ARObjectData arObjectData)
    {
        Instantiate(arObjectData.arObjectPrefab, arObjectContainer.position, Quaternion.identity, arObjectContainer);
    }
}

