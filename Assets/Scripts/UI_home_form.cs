using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//using UnityEngine.UI;

public class UI_home_form : MonoBehaviour
{
    public Toggle toggle_monuments;
    public Label full_distance;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        toggle_monuments = root.Q<Toggle>("toggle_monuments");
        full_distance = root.Q<Label>("full_distance");

        Debug.Log("toggle_monuments: " + toggle_monuments);

        //toggle_monuments.value += OnToggleMonuments;

    }

    void OnToggleMonuments()
    {
        Debug.Log("Toggle monuments");
        full_distance.text = "25";
        //full_distance.style.display = DisplayStyle.Flex;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
