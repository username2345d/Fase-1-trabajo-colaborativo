using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// References and variables used to control the scene.
// Includes character GameObjects, UI elements (text box, buttons, name display),
// and variables for handling dialogue (text content and length).
// Also manages event progression within the scene through eventPos.
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
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;

    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // This section controls each sequence.
    // It contains controllers for text, character appearance timing,and the buttons for each event.
    IEnumerator EventStarter() 
    {
        //event 0
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
        nextButton.SetActive(true);
        eventPos = 1;

    }

    IEnumerator EventOne()
    {
        //event 1
        nextButton.SetActive(false);
        charFhósSpeak1.SetActive(false);
        charFhósStopSpeak.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Advisor";      
        textToSpeak = "Your Majesty… the reports from the front are growing worse by the day.\r\nWe have completely lost control of the North.\r\nOur defenses will not withstand another attack, and the population is already falling into panic.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);       
        nextButton.SetActive(true);
        eventPos = 2;
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
    }


}
