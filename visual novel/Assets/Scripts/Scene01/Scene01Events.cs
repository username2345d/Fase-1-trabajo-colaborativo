using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{

    public GameObject FadeScreenIn;
    public GameObject charFhós;
    public GameObject charFhósStopSpeak;
    public GameObject charFhósSpeak1;
    public GameObject charNpc;
    public GameObject textBox;

    //AudioSource Pending
    //AudioSource Pending

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // This coroutine controls the entire initial sequence of Scene 01.
    // It is the main part of the events in this scene (intro cinematic) and character timings.
    IEnumerator EventStarter() 
    {
        yield return new WaitForSeconds(2);
        FadeScreenIn.SetActive(false);        

        yield return new WaitForSeconds(2);
        charFhós.SetActive(false);
        charFhósSpeak1.SetActive(true);
        mainTextObject.SetActive(true);
        textToSpeak = "We’ve lost the North… again.\r\nOur defenses are crumbling, the people are falling into panic, and here I stand… still searching for answers where there are none left.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        textBox.SetActive(true);
       

        yield return new WaitForSeconds(2);
        charFhósSpeak1.SetActive(false);
        charFhósStopSpeak.SetActive(true);

        yield return new WaitForSeconds(1);
        charNpc.SetActive(true);

    }


}
