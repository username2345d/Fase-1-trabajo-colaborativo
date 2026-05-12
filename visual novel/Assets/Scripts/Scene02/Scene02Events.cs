using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
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
        //event 0 - Inicio de escena
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);

        yield return new WaitForSeconds(1f);

        charThalassaSpeakAnim.SetActive(true);
        charFhósAnim.SetActive(true);
        
        mainTextObject.SetActive(true);
        textBox.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Thalassa";
        textToSpeak = "Fhós… You can still stop this.\r\nYou don’t have to keep carrying everything alone.";
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
        textToSpeak = "It’s not that simple.\r\nIf I let go now, everything falls apart.";
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
        textToSpeak = "Look at yourself. That light is consuming you alive.\r\nHow much longer do you think you can endure this?";
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
        charFhósIdle.SetActive(false);
        charFhósSpeak1.SetActive(true);
        charThalassaSpeak1.SetActive(false);
        charThalassaIdle.SetActive(true);

        charName.GetComponent<TMPro.TMP_Text>().text = "Fhós";
        textToSpeak = "As long as necessary.\r\nSomeone has to hold it together.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.3f);

        nextButton.SetActive(true);
        eventPos = 4;
    }


    public void NextButton()
    {
        if (eventPos == 1) StartCoroutine(EventOne());
        else if (eventPos == 2) StartCoroutine(EventTwo());
        else if (eventPos == 3) StartCoroutine(EventThree());        
        
    }
}