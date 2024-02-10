using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using TMPro;


public class Toggle_element : MonoBehaviour
{

    //public Label full_distance;
    public TextMeshProUGUI full_distance;
    public int distance_value = 0;

    public void OnToggleMonuments(Toggle toggle_monuments)
    {

        if (toggle_monuments.isOn)
        {
            distance_value += 25;
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
        Debug.Log("Monuments Toggle" + distance_value.ToString());

    }

    public void OnToggleOeuvres(Toggle toggle_oeuvres)
    {
        if (toggle_oeuvres.isOn)
        {
            distance_value += 25;
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
        Debug.Log("Oeuvres Toggle" + distance_value.ToString());

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("toggle oeuvres " + PlayerPrefs.GetInt("Oeuvres").ToString());
        PlayerPrefs.SetInt("Monuments", 0);
        PlayerPrefs.SetInt("Oeuvres", 0);
        PlayerPrefs.SetInt("Distance", 50);



        // DontDestroyOnLoad(this.fullData);

        //var root = GetComponent<UIDocument>().rootVisualElement;
        //full_distance = root.Q<Label>("full_distance");

        full_distance.text = PlayerPrefs.GetInt("Distance").ToString();
    }



    // Update is called once per frame
    void Update()
    {


    }

    void Log()
    {

        //Debug.Log("Variables : " + variables.full_time.ToString());
        Debug.Log("Prefs : " + PlayerPrefs.GetInt("Monuments").ToString());
    }
}
