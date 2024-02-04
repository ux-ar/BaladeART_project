using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using TMPro;


public class Toggle_element : MonoBehaviour
{
    Variables variables = new Variables();

    //public Label full_distance;
    public TextMeshProUGUI full_distance;
    public int distance_value = 0;

    public bool[] fullData = { false, false };
    //PlayerPrefs PlayerPrefsVar = new PlayerPrefs();

    public void OnToggleMonuments(Toggle toggle_monuments)
    {

        Debug.Log("Monuments Toggle" + distance_value.ToString());
        if (toggle_monuments.isOn)
        {
            distance_value += 25;
            fullData[0] = true;
            PlayerPrefs.SetInt("Monuments", 1);

        }
        else
        {
            distance_value -= 25;
            PlayerPrefs.SetInt("Monuments", 0);
        }
        //full_distance.text = distance_value.ToString();
        //full_distance.style.display = DisplayStyle.Flex;

        PlayerPrefs.SetInt("Distance", distance_value);
        Log();
    }

    public void OnToggleOeuvres(Toggle toggle_oeuvres)
    {
        Debug.Log("Oeuvres Toggle" + distance_value.ToString());
        if (toggle_oeuvres.isOn)
        {
            distance_value += 25;
            fullData[1] = true;
            PlayerPrefs.SetInt("Oeuvres", 1);
        }
        else
        {
            distance_value -= 25;
            PlayerPrefs.SetInt("Oeuvres", 0);
        }
        //full_distance.text = distance_value.ToString();
        //full_distance.style.display = DisplayStyle.Flex;
        PlayerPrefs.SetInt("Distance", distance_value);
        Log();
    }

    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("Monuments", 0);
        PlayerPrefs.SetInt("Oeuvres", 0);
        PlayerPrefs.SetInt("Distance", 50);

        Log();

        // DontDestroyOnLoad(this.fullData);

        //var root = GetComponent<UIDocument>().rootVisualElement;
        //full_distance = root.Q<Label>("full_distance");



        distance_value = 50;
        full_distance.text = distance_value.ToString();


    }



    // Update is called once per frame
    void Update()
    {
        full_distance.text = PlayerPrefs.GetInt("Distance").ToString();

    }

    void Log()
    {

        Debug.Log("Variables : " + variables.full_time.ToString());
        Debug.Log("Prefs : " + PlayerPrefs.GetInt("Monuments").ToString());
    }
}
