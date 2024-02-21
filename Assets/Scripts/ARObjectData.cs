using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ARObjectData
{
    public int id;
    public string name;
    public float minLatitude;
    public float maxLatitude;
    public float minLongitude;
    public float maxLongitude;
    public string text;
    public bool isMonument;
    public bool isOeuvre;  

    public ARObjectData(int id, string name, float minLatitude, float maxLatitude, float minLongitude, float maxLongitude, string text, bool isMonument, bool isOeuvre){
        this.id = id;
        this.name = name;
        this.minLatitude = minLatitude;
        this.maxLatitude = maxLatitude;
        this.minLongitude = minLongitude;
        this.maxLongitude = maxLongitude;
        this.text = text;
        this.isMonument = isMonument;
        this.isOeuvre = isOeuvre;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float MinLatitude
    {
        get { return minLatitude; }
        set { minLatitude = value; }
    }

    public float MaxLatitude
    {
        get { return maxLatitude; }
        set { maxLatitude = value; }
    }

    public float MinLongitude
    {
        get { return minLongitude; }
        set { minLongitude = value; }
    }

    public float MaxLongitude
    {
        get { return maxLongitude; }
        set { maxLongitude = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public bool IsMonument
    {
        get { return isMonument; }
        set { isMonument = value; }
    }

    public bool IsOeuvre
    {
        get { return isOeuvre; }
        set { isOeuvre = value; }
    }


}
