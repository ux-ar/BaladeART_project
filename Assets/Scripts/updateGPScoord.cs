using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGPScoord : MonoBehaviour
{
    public Text coordinates;

    private void Update()
    {
        coordinates.text = "Lat: " + GPS.Instance.latitude.ToString() + "     Lon: " + GPS.Instance.longitude.ToString();

    }
}
