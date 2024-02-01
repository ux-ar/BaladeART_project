using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonPanel : MonoBehaviour
{
    public GameObject myButton;
    public int myMessage;
    private void Start()
    {
        myButton.SetActive(false);
        Debug.Log(myMessage);
        Show(myMessage);
    }

    public void Show(int num)
    {
        if (num == 1) { myButton.SetActive(true); }

       
    }

    
}
