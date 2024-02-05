using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public static GPS Instance { get; private set; }

    Init Init = new Init();

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

        Debug.Log(Init.latitude);
        Debug.Log(Init.arObjectDataList);
    }

    private void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)

        {
            // Mettre à jour les coordonnées GPS à chaque itération de la boucle de mise à jour du jeu
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
        }
        // Vérifier pour chaque objet AR si la position est ok
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
        float errorMargin = 10f;
        return Mathf.Abs(latitude - targetLatitude) < errorMargin && Mathf.Abs(longitude - targetLongitude) < errorMargin;
    }

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
        // Utiliser directement les latitudes et longitudes sans conversion en unités de distance
        float latitudeScale = 1f; // Échelle de latitude (1 degré de latitude = 1 unité de distance Unity)
        float longitudeScale = 1f; // Échelle de longitude (1 degré de longitude = 1 unité de distance Unity)

        float x = (targetLongitude - longitude) * longitudeScale;
        float z = (targetLatitude - latitude) * latitudeScale;

        return new Vector3(x, 0, z);
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

        yield break;
    }
}