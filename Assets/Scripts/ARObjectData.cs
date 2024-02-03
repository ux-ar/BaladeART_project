using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ARObjectData
{
    public int id;
    public string name;
    public float latitude;
    public float longitude;
    public GameObject arObjectPrefab;
    public string text;
    public bool isMonument;
    public bool isOeuvre;  

}
