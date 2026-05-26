using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene03Events : MonoBehaviour
{
    // === Fades ===
    public GameObject FadeScreenIn;
    public GameObject FadeOut;

    // === Characters ===
    public GameObject charFhósIdle;
    public GameObject charFhósSpeak1;
    public GameObject charFhósSpeak2;
    public GameObject charFhósAnim;

    public GameObject charThalassaIdle;
    public GameObject charThalassaSpeak1;
    public GameObject charThalassaSpeakAnim;

    public GameObject charVarkasIdle;
    public GameObject charVarkasSpeak;
    public GameObject charVarkasAnim;

    // === UI ===
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject choicePanel;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] int eventPos = 0;

    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);

        yield return new WaitForSeconds(1f);

        charFhósAnim.SetActive(true);
        charThalassaSpeakAnim.SetActive(true);
        mainTextObject.SetActive(true);
        textBox.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "Fhós, stop! Please!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        charThalassaSpeakAnim.SetActive(false);
        charThalassaIdle.SetActive(true);
        charFhósAnim.SetActive(false);
        charFhósSpeak1.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Fhós";
        textToSpeak = "I can't stop anymore.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        nextButton.SetActive(false);
        charFhósSpeak1.SetActive(false);
        charFhósIdle.SetActive(true);
        charThalassaIdle.SetActive(false);
        charThalassaSpeak1.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "Then flee with us! There is still time.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventThree()
    {
        nextButton.SetActive(false);
        charThalassaSpeak1.SetActive(false);
        charThalassaIdle.SetActive(true);
        charFhósIdle.SetActive(false);
        charFhósSpeak2.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Fhós";
        textToSpeak = "A king may abandon his crown… but not the consequences of his decisions.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        nextButton.SetActive(false);
        charFhósSpeak2.SetActive(false);
        charFhósIdle.SetActive(true);
        charVarkasAnim.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Varkas";
        textToSpeak = "Your Majesty… If the core falls, everything will disappear.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        nextButton.SetActive(false);
        charVarkasAnim.SetActive(false);
        charVarkasIdle.SetActive(true);
        charFhósIdle.SetActive(false);
        charFhósSpeak1.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Fhós";
        textToSpeak = "Only what should never have existed will disappear.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        nextButton.SetActive(false);
        charFhósSpeak1.SetActive(false);
        charFhósIdle.SetActive(true);
        charThalassaIdle.SetActive(false);
        charThalassaSpeak1.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "Fhós… What are you going to do?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 7;
    }

    IEnumerator EventSeven()
    {
        nextButton.SetActive(false);
        charThalassaSpeak1.SetActive(false);
        charThalassaIdle.SetActive(true);
        charFhósIdle.SetActive(false);
        charFhósSpeak2.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Fhós";
        textToSpeak = "All this time I tried to control the light… when I only had to let it go.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 8;
    }

    IEnumerator EventEight()
    {
        nextButton.SetActive(false);
        charFhósSpeak2.SetActive(false);
        charFhósIdle.SetActive(true);
        charThalassaIdle.SetActive(false);
        charThalassaSpeak1.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "This is your last chance! Choose!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        // === Ocultar todo antes del panel de eleccion ===
        nextButton.SetActive(false);
        mainTextObject.SetActive(false);
        textBox.SetActive(false);

        charFhósIdle.SetActive(false);
        charFhósSpeak1.SetActive(false);
        charFhósSpeak2.SetActive(false);
        charFhósAnim.SetActive(false);
        charThalassaIdle.SetActive(false);
        charThalassaSpeak1.SetActive(false);
        charThalassaSpeakAnim.SetActive(false);
        charVarkasIdle.SetActive(false);
        charVarkasSpeak.SetActive(false);
        charVarkasAnim.SetActive(false);

        choicePanel.SetActive(true);
    }

    // === RUTAS DE DECISION ===

    public void ChoiceLiberation()
    {
        choicePanel.SetActive(false);
        mainTextObject.SetActive(true);
        textBox.SetActive(true);
        StartCoroutine(EndingLiberation());
    }

    public void ChoiceSacrifice()
    {
        choicePanel.SetActive(false);
        mainTextObject.SetActive(true);
        textBox.SetActive(true);
        StartCoroutine(EndingSacrifice());
    }

    public void ChoiceVanishing()
    {
        choicePanel.SetActive(false);
        mainTextObject.SetActive(true);
        textBox.SetActive(true);
        StartCoroutine(EndingVanishing());
    }

    IEnumerator EndingLiberation()
    {
        charFhósAnim.SetActive(true);
        charThalassaSpeakAnim.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "You did it… The true sun rises.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(4f);

        StartCoroutine(EndingSequence());
    }

    IEnumerator EndingSacrifice()
    {
        charFhósAnim.SetActive(true);
        charVarkasSpeak.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Varkas";
        textToSpeak = "Your Majesty…";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.5f);

        charVarkasSpeak.SetActive(false);
        charVarkasIdle.SetActive(true);
        charThalassaSpeakAnim.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "No!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(4f);

        StartCoroutine(EndingSequence());
    }

    IEnumerator EndingVanishing()
    {
        charFhósAnim.SetActive(true);
        charThalassaSpeakAnim.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "Fhós…";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(4f);

        StartCoroutine(EndingSequence());
    }

    IEnumerator EndingSequence()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2f);

        charFhósAnim.SetActive(false);
        charFhósIdle.SetActive(false);
        charFhósSpeak1.SetActive(false);
        charFhósSpeak2.SetActive(false);
        charThalassaSpeakAnim.SetActive(false);
        charThalassaIdle.SetActive(false);
        charThalassaSpeak1.SetActive(false);
        charVarkasAnim.SetActive(false);
        charVarkasIdle.SetActive(false);
        charVarkasSpeak.SetActive(false);

        SceneManager.LoadScene(4);
    }

    public void NextButton()
    {
        if (eventPos == 1) StartCoroutine(EventOne());
        else if (eventPos == 2) StartCoroutine(EventTwo());
        else if (eventPos == 3) StartCoroutine(EventThree());
        else if (eventPos == 4) StartCoroutine(EventFour());
        else if (eventPos == 5) StartCoroutine(EventFive());
        else if (eventPos == 6) StartCoroutine(EventSix());
        else if (eventPos == 7) StartCoroutine(EventSeven());
        else if (eventPos == 8) StartCoroutine(EventEight());
    }
}