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
    public GameObject charFhósSpeak2;
    public GameObject charFhósSpeak3;
    public GameObject charSpeakAngry;
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

    IEnumerator EventTwo()
    {
        //event 2
        nextButton.SetActive(false);
        charFhósStopSpeak.SetActive(false);
        charFhósSpeak1.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "King Fhós";
        textToSpeak = "The cost of doing nothing… we are already paying it.\r\nThe only difference… is whether we are willing to accept it.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);               
        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        //event 3
        nextButton.SetActive(false);        
        charFhósSpeak1.SetActive(false);
        charFhósStopSpeak.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Advisor";
        textToSpeak = "That is madness, Your Majesty!\r\nYou cannot control something like that!\r\nThe cost would be incalculable!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //event 4
        nextButton.SetActive(false);
        charFhósStopSpeak.SetActive(false);
        charFhósSpeak3.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "King Fhós";
        textToSpeak = "Then let the world judge me…\r\nbut let it survive.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        //event 5
        nextButton.SetActive(false);
        charFhósSpeak3.SetActive(false);
        charFhósSpeak2.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "King Fhós";
        textToSpeak = "The heart of the sun…";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        //event 6
        nextButton.SetActive(false);        
        charFhósSpeak2.SetActive(false);
        charSpeakAngry.SetActive(true);
        charNpc.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "King Fhós";
        textToSpeak = "It is not just power… it is control.\r\nIt is… a solution.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }


    }


}
