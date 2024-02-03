using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements; 
using TMPro;


public class Variables
{
    //public int full_time = 20;
    public int full_time
    {
        get;
        set;
    }

    public TextMeshProUGUI test;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        test.text = full_time.ToString();

    }
}
