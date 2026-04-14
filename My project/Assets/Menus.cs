using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void Info()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

      public void Start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }



}