using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class Map : MonoBehaviour
{
    public string apiKey;
    public string FakeApiKey;
    public float lat = 48.892085864409815f;
    public float lon = 2.235504196336084f;
    public int zoom = 24;
    public enum resolution { low = 1, high = 2 };
    public resolution mapResolution = resolution.low;
    public enum type { roadmap, satellite, gybrid, terrain };
    public type mapType = type.roadmap;
    private string url = "";
    private int mapWidth = 1000;//640
    private int mapHeight = 1400;//640
    private bool mapIsLoading = false; //not used. Can be used to know that the map is loading 
    private Rect rect;

    private string apiKeyLast;
    private float latLast = 48.892085864409815f;
    private float lonLast = 2.235504196336084f;
    private int zoomLast = 14;
    private resolution mapResolutionLast = resolution.low;
    private type mapTypeLast = type.roadmap;
    private bool updateMap = true;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Update Map " + PlayerPrefs.GetFloat("Latitude").ToString() + " " + PlayerPrefs.GetFloat("Longitude").ToString());
        StartCoroutine(GetGoogleMap());
        rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
        mapWidth = (int)Math.Round(rect.width);
        mapHeight = (int)Math.Round(rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        if (updateMap && (apiKeyLast != apiKey || !Mathf.Approximately(latLast, lat) || !Mathf.Approximately(lonLast, lon) || zoomLast != zoom || mapResolutionLast != mapResolution || mapTypeLast != mapType))
        {
            Debug.Log("Update Map " + PlayerPrefs.GetFloat("Latitude").ToString() + " " + PlayerPrefs.GetFloat("Longitude").ToString());
            rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
            mapWidth = (int)Math.Round(rect.width);
            mapHeight = (int)Math.Round(rect.height);
            StartCoroutine(GetGoogleMap());
            updateMap = false;
        }
    }


    IEnumerator GetGoogleMap()
    {
        // Construct the URL with markers and path
        string markers = "markers=color:yellow%7Clabel:M%7C" + lat + "," + lon +
                         "&markers=color:blue%7Clabel:B%7C48.89236030157794,2.2339412677534805" +
                         "&markers=color:blue%7Clabel:B%7C48.89353003365533,2.2387619275749735" +
                         "&markers=color:blue%7Clabel:B%7C48.89180299042522,2.2420075139993325" +
                         "&markers=color:blue%7Clabel:B%7C48.88912780661263,2.247817853100024" +
                         "&markers=color:purple%7Clabel:A%7C48.890431636837846,2.2432611842323156" +
                         "&markers=color:purple%7Clabel:A%7C48.88855573411807,2.242098775057336" +
                         "&markers=color:purple%7Clabel:A%7C48.88889626132014,2.2518710261124295" +
                         "&markers=color:purple%7Clabel:A%7C48.88704159194323,2.2514163837831633" +
                         "&markers=color:purple%7Clabel:A%7C48.89285130303518,2.239514768441741";

        string path = "&path=color:0x0000ff|weight:5|" + lat + "," + lon + "|48.89236030157794,2.2339412677534805|" +
                      "48.89353003365533,2.2387619275749735|48.89180299042522,2.2420075139993325|" +
                      "48.88912780661263,2.247817853100024|48.890431636837846,2.2432611842323156|" +
                      "48.88855573411807,2.242098775057336|48.88889626132014,2.2518710261124295|" +
                      "48.88704159194323,2.2514163837831633|48.89285130303518,2.239514768441741";

        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lon +
              "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + mapResolution +
              "&maptype=" + mapType + "&key=" + apiKey + "&" + markers + path;

        mapIsLoading = true;
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("WWW ERROR: " + www.error);
        }
        else
        {
            mapIsLoading = false;
            gameObject.GetComponent<RawImage>().texture = ((DownloadHandlerTexture)www.downloadHandler).texture;

            apiKeyLast = apiKey;
            latLast = lat;
            lonLast = lon;
            zoomLast = zoom;
            mapResolutionLast = mapResolution;
            mapTypeLast = mapType;
            updateMap = true;
        }
    }



}