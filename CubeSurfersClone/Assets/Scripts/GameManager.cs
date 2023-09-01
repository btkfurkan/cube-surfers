using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject canvas2;
    public GameObject canvas;
    public TextMeshProUGUI hpText;
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0.0f;
        canvas2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void StartGame()
    {

        Time.timeScale = 1.0f;
        canvas.SetActive(false);
        canvas2.SetActive(true);

    }

    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }

}
