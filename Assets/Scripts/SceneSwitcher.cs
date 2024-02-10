using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject gpsObject; // Référence à l'objet GPS

    public GameObject canvas;

    //PlayerPrefs PlayerPrefs = new PlayerPrefs();

    // Start is called before the first frame update
    void Start()
    {
        // Assurez-vous que l'objet GPS est présent dans la scène
        if (gpsObject != null)
        {
            // Obtenez ou ajoutez le composant GPS à l'objet GPS
            Init gps = gpsObject.GetComponent<Init>();

            // Si le composant GPS n'existe pas, ajoutez-le
            if (gps == null)
            {
                gps = gpsObject.AddComponent<Init>();
            }

            // Démarrez le service de localisation
            StartCoroutine(gps.StartLocationService());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        Debug.Log(PlayerPrefs.GetInt("Monuments"));
    }

    public void LoadCanvas(GameObject currentCanvas)
    {
        GameObject[] canvases = GameObject.FindGameObjectsWithTag("Canvas");
        foreach (GameObject canvas in canvases)
        {
            canvas.SetActive(false);
        }
        currentCanvas.SetActive(true);
    }
}
