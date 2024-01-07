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
    public float displayDistance = 10f; // Définir la distance à laquelle afficher le prefab

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
            yield return null;
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

    /*private void InstantiateARObject(ARObjectData arObjectData)
    {
        // Utiliser les coordonnées géographiques pour déterminer la position
        Vector3 position = GetARObjectPosition(arObjectData.latitude, arObjectData.longitude);

        // Instancier l'objet AR à la position calculée
        Instantiate(arObjectData.arObjectPrefab, position, Quaternion.identity, arObjectContainer);
    }*/


    private void InstantiateARObject(ARObjectData arObjectData)
    {
        // Utiliser les coordonnées géographiques pour déterminer la position
        Vector3 position = GetARObjectPosition(arObjectData.latitude, arObjectData.longitude);

        // Vérifier la distance entre la position actuelle et la position cible
        float distance = Vector3.Distance(transform.position, position);

        // Si la distance est inférieure ou égale à la distance de visualisation spécifiée, alors instancier l'objet AR
        if (distance <= displayDistance)
        {
            // Instancier l'objet AR à la position calculée
            Instantiate(arObjectData.arObjectPrefab, position, Quaternion.identity, arObjectContainer);
        }
    }



    private Vector3 GetARObjectPosition(float targetLatitude, float targetLongitude)
    {
        // Utiliser une méthode appropriée pour convertir les coordonnées géographiques en position dans Unity
        // Cela dépendra de votre échelle et de la manière dont vous avez défini les positions géographiques par rapport à Unity.
        // Vous pouvez utiliser des fonctions de projection cartographique ou d'autres méthodes en fonction de vos besoins.

        // À titre d'exemple, une conversion simple en utilisant directement les latitudes et longitudes :
        float latitudeScale = 11100; // 1 degré de latitude = environ 11.1 km
        float longitudeScale = 11100; // À des fins de démonstration, on suppose une échelle constante pour la longitude

        float x = (targetLongitude - longitude) * longitudeScale;
        float z = (targetLatitude - latitude) * latitudeScale;

        return new Vector3(x, 0, z);
    }
}
