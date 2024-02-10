using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Init : MonoBehaviour
{
    #region Variables

    public static Init Instance { get; private set; }

    public int id = 1;
    public List<int> listIndex = new List<int>();
    public List<ARObjectData> dataList;
    public Transform arObjectContainer;
    public float displayDistance = 100f; // Définir la distance à laquelle afficher le prefab

    public TextMeshProUGUI loc_text;
    public TextMeshProUGUI debug1;
    public TextMeshProUGUI debug2;

    public TextMeshProUGUI popupTitle;
    public TextMeshProUGUI popupText;

    public TextMeshProUGUI debugTextTmp;

    public float currentLatitude;
    public float currentLongitude;

    string debugText = "";

    #endregion
    #region Init

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        StartCoroutine(StartLocationService());


        // to remove and use with toggleElements
        PlayerPrefs.SetInt("Monuments", 1);
        PlayerPrefs.SetInt("Oeuvres", 1);

        // Location for map 
        PlayerPrefs.SetFloat("Latitude", currentLatitude);
        PlayerPrefs.SetFloat("Longitude", currentLongitude);

        defineList();

        //Debug.Log(dataList[0].name);
        //Debug.Log(Instance.dataList[0].name);
    }
    private void Update()
    {


        // debug1.text = "name";
        // Debug.Log("toggle oeuvres " + PlayerPrefs.GetInt("Oeuvres").ToString());


        debug2.text = PlayerPrefs.GetInt("Distance").ToString();
        debugText += "Distance " + PlayerPrefs.GetInt("Distance").ToString();

        debugText += "list count " + listIndex.Count.ToString();
        debugText += "list index ";
        for (int i = 0; i < listIndex.Count; i++)
        {
            debugText += listIndex[i].ToString() + ",";
        }

        // Deisplay current location
        loc_text.text = "Latitude: " + currentLatitude.ToString() + " Longitude: " + currentLongitude.ToString();


        // Debug ar object
        for (int i = 0; i < dataList.Count; i++)
        {
            if (id == dataList[i].id)
            {
                // Debug.Log(dataList[i].arObjectPrefab.name);
                debug1.text = dataList[i].name;
            }
        }


        UpdatePopup();

        UpdateGps();


        debugTextTmp.text = debugText;
        debugText = "";
    }

    #endregion
    #region Methods

    public void UpdatePopup()
    {
        for (int i = 0; i < dataList.Count; i++)
        {
            if (id == dataList[i].id)
            {
                popupTitle.text = dataList[i].name;
                popupText.text = dataList[i].text;
            }
        }
    }

    public void UpdateGps()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            // Mettre à jour les coordonnées GPS à chaque itération de la boucle de mise à jour du jeu
            currentLatitude = Input.location.lastData.latitude;
            currentLongitude = Input.location.lastData.longitude;


            // Location for map 
            PlayerPrefs.SetFloat("Latitude", currentLatitude);
            PlayerPrefs.SetFloat("Longitude", currentLongitude);
        }

        // Vérifier pour chaque objet AR si la position est ok
        foreach (ARObjectData arObjectData in dataList)
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
        return Mathf.Abs(currentLatitude - targetLatitude) < errorMargin && Mathf.Abs(currentLongitude - targetLongitude) < errorMargin;
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

        float x = (targetLongitude - currentLongitude) * longitudeScale;
        float z = (targetLatitude - currentLatitude) * latitudeScale;

        return new Vector3(x, 0, z);
    }


    public void defineList()
    {
        // check what is selected from the homepage
        bool monument = PlayerPrefs.GetInt("Monuments") == 1;
        bool oeuvre = PlayerPrefs.GetInt("Oeuvres") == 1;

        listIndex.Clear();


        Debug.Log("oeuvre" + oeuvre.ToString());
        if (monument)
        {
            if (oeuvre)
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    listIndex.Add(dataList[i].id);
                }

            }
            else
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    if (dataList[i].isMonument)
                    {
                        listIndex.Add(dataList[i].id);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].isOeuvre)
                {
                    listIndex.Add(dataList[i].id);
                }
            }
        }
    }

    #endregion
    #region Gps

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


    #endregion

}