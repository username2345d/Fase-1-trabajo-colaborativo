using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] AudioSource buttonClick;

    void Start()
    {
        
    }

    public void StartGame()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToClassScene());
    }

    
    void Update()
    {
        
    }

    IEnumerator TransferToClassScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
