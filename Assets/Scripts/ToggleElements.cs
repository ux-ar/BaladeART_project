using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using TMPro;


public class Toggle_element : MonoBehaviour
{


    public Toggle toggle_monuments;
    public Toggle toggle_oeuvres;
    public TextMeshProUGUI full_distance;
    public TextMeshProUGUI full_time;
    public TextMeshProUGUI full_elevation;
    private int distance_value = 0;
    private int time_value = 0;
    private int elevation_value = 0;
    public int distance_monuments = 25;
    public int distance_oeuvres = 10;
    public int time_monuments = 10;
    public int time_oeuvres = 5;
    public int elevation_monuments = 10;
    public int elevation_oeuvres = 20;


    public void OnToggleMonuments()
    {

        if (toggle_monuments.isOn)
        {
            distance_value += distance_monuments;
            time_value += time_monuments;
            elevation_value += elevation_monuments;
            PlayerPrefs.SetInt("Monuments", 1);

        }
        else
        {
            distance_value -= distance_monuments;
            time_value -= time_monuments;
            elevation_value -= elevation_monuments;
            PlayerPrefs.SetInt("Monuments", 0);
        }
        //full_distance.text = distance_value.ToString();
        //full_distance.style.display = DisplayStyle.Flex;

        PlayerPrefs.SetInt("Distance", distance_value);
        Debug.Log("Monuments Toggle" + distance_value.ToString());

    }

    public void OnToggleOeuvres()
    {
        if (toggle_oeuvres.isOn)
        {
            distance_value += distance_oeuvres;
            time_value += time_oeuvres;
            elevation_value += elevation_oeuvres;
            PlayerPrefs.SetInt("Oeuvres", 1);
        }
        else
        {
            distance_value -= distance_oeuvres;
            time_value -= time_oeuvres;
            elevation_value -= elevation_oeuvres;
            PlayerPrefs.SetInt("Oeuvres", 0);
        }
        //full_distance.text = distance_value.ToString();
        //full_distance.style.display = DisplayStyle.Flex;
        PlayerPrefs.SetInt("Distance", distance_value);
        Debug.Log("Oeuvres Toggle" + distance_value.ToString());

    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("toggle oeuvres " + PlayerPrefs.GetInt("Oeuvres").ToString());
        // PlayerPrefs.SetInt("Monuments", toggle_monuments.isOn == true ? 1 : 0);
        // PlayerPrefs.SetInt("Oeuvres", toggle_oeuvres.isOn == true ? 1 : 0);


        distance_value = distance_monuments + distance_oeuvres;
        time_value = time_monuments + time_oeuvres;
        elevation_value = elevation_monuments + elevation_oeuvres;

        if (PlayerPrefs.GetInt("Distance") != null)
        {
            distance_value = PlayerPrefs.GetInt("Distance");
        }
        else
        {
            PlayerPrefs.SetInt("Distance", distance_value);
        }



        if (PlayerPrefs.GetInt("Monuments") != null)
        {
            toggle_monuments.isOn = PlayerPrefs.GetInt("Monuments") == 1 ? true : false;
        }
        else
        {
            PlayerPrefs.SetInt("Monuments", toggle_monuments.isOn == true ? 1 : 0);
        }

        if (PlayerPrefs.GetInt("Oeuvres") != null)
        {
            toggle_oeuvres.isOn = PlayerPrefs.GetInt("Oeuvres") == 1 ? true : false;
        }
        else
        {
            PlayerPrefs.SetInt("Ouvres", toggle_oeuvres.isOn == true ? 1 : 0);
        }




        // DontDestroyOnLoad(this.fullData);

        //var root = GetComponent<UIDocument>().rootVisualElement;
        //full_distance = root.Q<Label>("full_distance");

    }



    // Update is called once per frame
    void Update()
    {

        full_distance.text = distance_value.ToString();
        full_time.text = time_value.ToString();
        full_elevation.text = elevation_value.ToString();

        PlayerPrefs.SetInt("Distance", distance_value);
        PlayerPrefs.SetInt("Time", time_value);
        PlayerPrefs.SetInt("Elevation", elevation_value);

    }

    void Log()
    {

        //Debug.Log("Variables : " + variables.full_time.ToString());
        Debug.Log("Prefs : " + PlayerPrefs.GetInt("Monuments").ToString());
    }
}
