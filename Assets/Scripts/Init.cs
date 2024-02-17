using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Init : MonoBehaviour
{
    #region Variables

    public static Init Instance { get; private set; }

    public int runningId = 1;
    public TextMeshProUGUI runningText;
    public List<int> runningList = new List<int>();
    public List<ARObjectData> dataList;
    public Transform arObjectContainer;
    public float displayDistance = 50f; // Définir la distance à laquelle afficher le prefab

    public TextMeshProUGUI loc_text;
    public TextMeshProUGUI debug1;
    public TextMeshProUGUI debug2;

    public TextMeshProUGUI popupTitle;
    public TextMeshProUGUI popupText;

    public TextMeshProUGUI debugTextTmp;

    public float currentLatitude;
    public float currentLongitude;

    public TextMeshProUGUI full_distance;
    public TextMeshProUGUI full_time;
    public TextMeshProUGUI full_elevation;

    string debugText = "";

    #endregion
    #region Init

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        StartCoroutine(StartLocationService());


        // to remove and use with toggleElements
        //PlayerPrefs.SetInt("Monuments", 1);
        //PlayerPrefs.SetInt("Oeuvres", 1);

        // Location for map 
        PlayerPrefs.SetFloat("Latitude", currentLatitude);
        PlayerPrefs.SetFloat("Longitude", currentLongitude);

        PlayerPrefs.SetInt("RunningId", runningId);

        defineList();

        //Debug.Log(dataList[0].name);
        //Debug.Log(Instance.dataList[0].name);
    }
    private void Update()
    {

        runningId = PlayerPrefs.GetInt("RunningId");

        // debug1.text = "name";
        // Debug.Log("toggle oeuvres " + PlayerPrefs.GetInt("Oeuvres").ToString());


        debug2.text = PlayerPrefs.GetInt("Distance").ToString();

        // Deisplay current location
        loc_text.text = "Latitude: " + currentLatitude.ToString() + " Longitude: " + currentLongitude.ToString();


        // Debug ar object
        for (int i = 0; i < dataList.Count; i++)
        {
            if (runningId == dataList[i].id)
            {
                // Debug.Log(dataList[i].arObjectPrefab.name);
                debug1.text = dataList[i].name;
            }
        }

        runningText.text = runningId.ToString();

        UpdateWalk();
        UpdatePopup();
        UpdateGps();
        DebugLog();
        UpdateList();

    }
    public void DebugLog()
    {
        debugText += "Latitude " + currentLatitude.ToString() + "\n";
        debugText += "Longitude " + currentLongitude.ToString() + "\n";

        debugText += "Distance Pref" + PlayerPrefs.GetInt("Distance").ToString() + "\n";
        debugText += "Monuments Pref" + PlayerPrefs.GetInt("Monuments").ToString() + "\n";
        debugText += "Oeuvres Pref" + PlayerPrefs.GetInt("Oeuvres").ToString() + "\n";
        debugText += "running id " + runningId.ToString() + "\n";
        for (int i = 0; i < dataList.Count; i++)
        {
            if (runningId == dataList[i].id)
            {
                debugText += "running name " + dataList[i].name + "\n";
            }
        }
        debugText += "list count " + runningList.Count.ToString() + "\n";
        debugText += "list index ";
        for (int i = 0; i < runningList.Count; i++)
        {
            debugText += runningList[i].ToString() + ",";
        }
        debugText += "\n";

        debugTextTmp.text = debugText;
        debugText = "";

    }

    #endregion
    #region Methods

    public void UpdateWalk()
    {
        full_distance.text = PlayerPrefs.GetInt("Distance").ToString();
        full_time.text = PlayerPrefs.GetInt("Time").ToString();
        full_elevation.text = PlayerPrefs.GetInt("Elevation").ToString();
    }
    public void UpdateList()
    {

        string runningListTmp = "";
        for (int i = 0; i < runningList.Count; i++)
        {
            runningListTmp += runningList[i].ToString() + ",";
        }
        PlayerPrefs.SetString("RunningList", runningListTmp);
        Debug.Log("running list " + PlayerPrefs.GetString("RunningList"));
    }
    public void RunningId(int id)
    {
        PlayerPrefs.SetInt("RunningId", id);
    }
    public bool CheckRunningId(int runningId, bool isNext)
    {
        //List<string> listString = new List<string>(PlayerPrefs.GetString("RunningList").Split(','));
        //List<int> runningListCheck = listString.Select(int.Parse).ToList();
        //List<int> listTemp = new List<int>(PlayerPrefs.GetString("RunningList").Split(',').Select(int.Parse));

        List<int> runningListCheck = new List<int>();
        List<string> listString = new List<string>(PlayerPrefs.GetString("RunningList").Split(','));
        foreach (string str in listString)
        {
            if (int.TryParse(str, out int result))
            {
                runningListCheck.Add(result);
            }
        }
        // check if the running id is in the list
        bool isRunningId = false;


        // for (int i = 0; i < runningListCheck.Count; i++)
        // {
        //     Debug.Log("id test " + runningListCheck[i].ToString());
        //     if (runningList.Contains(runningListCheck[i]))
        //     {
        //         isRunningId = true;
        //         break;
        //     }
        // }
        Debug.Log("running id " + runningId.ToString() + " list " + runningListCheck.Contains(runningId).ToString());
        isRunningId = runningListCheck.Contains(runningId);
        return isRunningId;

    }
    public void NextRunningId()
    {
        int tempId = PlayerPrefs.GetInt("RunningId");
        tempId++;
        if (CheckRunningId(tempId, true))
        {
            PlayerPrefs.SetInt("RunningId", tempId);
            Debug.Log("running id next " + PlayerPrefs.GetInt("RunningId").ToString());
        }
        else
        {
            Debug.Log("running id next " + "not in the list");

        }
    }
    public void PreviousRunningId()
    {
        int tempId = PlayerPrefs.GetInt("RunningId");
        tempId--;
        if (CheckRunningId(tempId, true))
        {
            PlayerPrefs.SetInt("RunningId", tempId);
            Debug.Log("running id next " + PlayerPrefs.GetInt("RunningId").ToString());
        }
        else
        {
            Debug.Log("running id next " + "not in the list");

        }
    }
    public void UpdatePopup()
    {
        for (int i = 0; i < dataList.Count; i++)
        {
            if (runningId == dataList[i].id)
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


        ARObjectData arObject = dataList.Find(obj => obj.id == runningId);
        if (arObject != null && IsTargetReached(arObject.latitude, arObject.longitude))
        {
            // Vérifier si l'objet avec runningId est déjà instancié
            GameObject existingObject = GameObject.Find(arObject.name);
            if (existingObject == null)
            {
                InstantiateARObject(arObject); // Instancier l'objet AR
            }
            /*else if (!IsInGPSRange(arObject.latitude, arObject.longitude)) // Vérifier si les coordonnées GPS actuelles sont hors de la plage
            {
                // Passer à l'ID suivant avec les fonctions du boutons
                //UpdateRunningId();
            }*/
        }


        // from the currentId list 
        /*if (runningList.Count > 0)
        {
            for (int i = 0; i < runningList.Count; i++)
            {
                // Vérifier pour chaque objet AR si la position est ok
                for (int j = 0; j < dataList.Count; j++)
                {
                    if (runningList[i] == dataList[j].id)
                    {
                        if (IsTargetReached(dataList[j].latitude, dataList[j].longitude))
                        {
                            runningId = dataList[j].id;
                            // runningList.RemoveAt(j);
                            InstantiateARObject(dataList[j]); // Instancier l'objet AR
                        }
                    }
                }
            }
        }*/

        // Vérifier pour chaque objet AR si la position est ok
        // foreach (ARObjectData arObjectData in dataList)
        // {
        //     if (IsTargetReached(arObjectData.latitude, arObjectData.longitude))
        //     {
        //         InstantiateARObject(arObjectData); // Instancier l'objet AR
        //     }
        // }
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

        runningList.Clear();


        Debug.Log("oeuvre" + oeuvre.ToString());
        if (monument)
        {
            if (oeuvre)
            {
                // monuments and oeuvres
                for (int i = 0; i < dataList.Count; i++)
                {
                    runningList.Add(dataList[i].id);
                }

            }
            else
            {
                // monuments only
                for (int i = 0; i < dataList.Count; i++)
                {
                    if (dataList[i].isMonument)
                    {
                        runningList.Add(dataList[i].id);
                    }
                }
            }
        }
        else
        {
            if (oeuvre)
            {
                // oeuvres only
                for (int i = 0; i < dataList.Count; i++)
                {
                    if (dataList[i].isOeuvre)
                    {
                        runningList.Add(dataList[i].id);
                    }
                }
            }
            else
            {
                // nothing selected
                runningList.Clear();
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