using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class updateGPScoord : MonoBehaviour
{
    public Text coordinates;

    public TextMeshProUGUI full_distance;

    Toggle_element Toggle_element = new Toggle_element();

    private void Update()
    {
        coordinates.text = "Lat: " + GPS.Instance.latitude.ToString() + "     Lon: " + GPS.Instance.longitude.ToString();

        full_distance.text = PlayerPrefs.GetInt("Distance").ToString();

    }
}
