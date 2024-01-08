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
        Debug.Log("Monuments Toggle" + distance_value.ToString());
        if (toggle_monuments.isOn)
        {
            distance_value += 25;
        }
        else
        {
            distance_value -= 25;
        }
        full_distance.text = distance_value.ToString();
        //full_distance.style.display = DisplayStyle.Flex;
    }

    // Start is called before the first frame update
    void Start()
    {

        //var root = GetComponent<UIDocument>().rootVisualElement;
        //full_distance = root.Q<Label>("full_distance");

        Debug.Log("START ");

        distance_value = 50;
        full_distance.text = distance_value.ToString();


    }



    // Update is called once per frame
    void Update()
    {

    }
}
