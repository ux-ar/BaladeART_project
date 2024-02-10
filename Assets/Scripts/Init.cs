using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Init : MonoBehaviour
{
    public static Init Instance { get; private set; }

    public int id = 1;
    public List<int> listIndex = new List<int>();
    public float latitude;
    public float longitude;
    public List<ARObjectData> dataList;
    public Transform arObjectContainer;
    public float displayDistance = 100f; // Définir la distance à laquelle afficher le prefab

    public TextMeshProUGUI loc_text;
    public TextMeshProUGUI debug1;
    public TextMeshProUGUI debug2;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        PlayerPrefs.SetInt("Monuments", 1);
        PlayerPrefs.SetInt("Oeuvres", 1);

        defineList();

        //Debug.Log(dataList[0].name);
        //Debug.Log(Instance.dataList[0].name);
    }
    private void Update()
    {

        // debug1.text = "name";
        Debug.Log("toggle oeuvres " + PlayerPrefs.GetInt("Oeuvres").ToString());

        debug2.text = PlayerPrefs.GetInt("Distance").ToString();
        loc_text.text = "Latitude: " + latitude.ToString() + " Longitude: " + longitude.ToString();

        for (int i = 0; i < dataList.Count; i++)
        {
            if (id == dataList[i].id)
            {
                Debug.Log(dataList[i].arObjectPrefab.name);
                debug1.text = dataList[i].name;
            }
        }
    }


    public void defineList()
    {

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

}