using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public static Init Instance { get; private set; }

    public float latitude;
    public float longitude;
    public List<ARObjectData> dataList;
    public Transform arObjectContainer;
    public float displayDistance = 100f; // Définir la distance à laquelle afficher le prefab

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}