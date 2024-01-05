using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
 
public class MyImage : Image
{
    public new class UxmlFactory : UxmlFactory<MyImage, Image.UxmlTraits>{}
 
    public MyImage()
    {
       
    }
}
 
 
public class image_ui_element : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
