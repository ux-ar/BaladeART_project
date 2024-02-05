using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class updateGPScoord : MonoBehaviour
{
    public Text coordinates;

    public TextMeshProUGUI full_distance;

    public TextMeshProUGUI test;
    public TextMeshProUGUI test2;

    Toggle_element Toggle_element = new Toggle_element();
    Init Init = new Init();
    RunningData RunningData = new RunningData();

    private void Start()
    {
        full_distance.text = PlayerPrefs.GetInt("Distance").ToString();
        Debug.Log("AR: ");
        Debug.Log(Init.Instance.dataList[0].text);
    }
    private void Update()
    {
        //coordinates.text = "Lat: " + GPS.Instance.latitude.ToString() + "     Lon: " + GPS.Instance.longitude.ToString();

        //full_distance.text = PlayerPrefs.GetInt("Distance").ToString();

        //test.text = Init.latitude.ToString() + " " + Init.longitude.ToString();

        //string dataName = "";
        //ARObjectData runningObject = Init.arObjectDataList[RunningData.defineRunningIndex(Init.arObjectDataList)];

        //test2.text = runningObject.name;

    }
}
